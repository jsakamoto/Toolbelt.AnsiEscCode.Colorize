# ANSI Escape Codes - Colorize [![NuGet Package](https://img.shields.io/nuget/v/Toolbelt.AnsiEscCode.Colorize.svg)](https://www.nuget.org/packages/Toolbelt.AnsiEscCode.Colorize/)

## Summary

Very simple and small .NET library to just only append ANSI color escape sequence to a string.

## Usage

**Step 1.** Install this package to the project.

If you use dotnet CLI, enter the command below at the project folder to do it.

```shell
> dotnet add package Toolbelt.AnsiEscCode.Colorize
```

**Step 2.** Add a declaration to your C# source code to make this library available, like this.

```csharp
// Top of your C# source file (.cs)
using System;
...
// 👇 Add this line.
using static Toolbelt.AnsiEscCode.Colorize;
...
```

**Step 3.** Just surround a text what you want to be colored by static methods that name is the color name.
(Those static methods are provided by `Colorize` static class.)

For example, if you implemented like this code,

```csharp
Console.WriteLine($"Hello,{Red("World")}");
```

You will get this.

![fig.1](https://raw.githubusercontent.com/jsakamoto/Toolbelt.AnsiEscCode.Colorize/master/.assets/fig.1.png)

## How does it work

What the static methods of `Colorize` static class does is,  just surround a text by ANSI color escape sequence code.

```
Red("World") ⇒ "\x1b[91m" + "World" + "\x1b[0m"
```

## Notice for Windows OS users

Unfortunately, some console environments on Windows OS have not enabled the ANSI escape code feature by default.

Therefore, to enable it, you may have to implement some code for enabling the ANSI escape code feature.

For example, at first, add a C# code as below to your project,

```csharp
// Add this C# code to your project.
using System;
using System.Runtime.InteropServices;

public static class AnsiCodeEnabler
{
  [DllImport("kernel32.dll")]
  private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

  [DllImport("kernel32.dll")]
  private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr GetStdHandle(int nStdHandle);

  [DllImport("kernel32.dll")]
  private static extern uint GetLastError();

  public static void Enable()
  {
    const int STD_OUTPUT_HANDLE = -11;
    const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
    const uint DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

    var iStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
    if (GetConsoleMode(iStdOut, out uint outConsoleMode))
    {
      outConsoleMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING | DISABLE_NEWLINE_AUTO_RETURN;
      SetConsoleMode(iStdOut, outConsoleMode);
    }
  }
}
```

and next, invoke it at the beginning  of your program.

```csharp
class Program
{
  static void Main(string[] args)
  {
    AnsiCodeEnabler.Enable(); // 👈 Invoke it.
    ...
```

## License

[The Unlicense](https://github.com/jsakamoto/Toolbelt.AnsiEscCode.Colorize/blob/master/LICENSE)

(Because, it's too small, it's too simple, and more, the originality in this library is almost none.)
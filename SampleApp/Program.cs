using System;
using static Toolbelt.AnsiEscCode.Colorize;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiCodeEnabler.Enable();

            Console.WriteLine($"This is {Red("Red")}.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"This is {("Red")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {Yellow("Yellow")}.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"This is {("Yellow")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {Cyan("Cyan")}.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"This is {("Cyan")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {Green("Green")}.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"This is {("Green")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {Blue("Blue")}.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"This is {("Blue")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {Magenta("Magenta")}.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"This is {("Magenta")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {White("White")}.");
            Console.WriteLine($"This is {Gray("Gray")}.");
            Console.WriteLine($"This is {Black("Black")}.");

            Console.WriteLine($"This is {DarkRed("DarkRed")}.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"This is {("DarkRed")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkYellow("DarkYellow")}.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"This is {("DarkYellow")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkCyan("DarkCyan")}.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"This is {("DarkCyan")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkGreen("DarkGreen")}.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"This is {("DarkGreen")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkBlue("DarkBlue")}.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"This is {("DarkBlue")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkMagenta("DarkMagenta")}.");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"This is {("DarkMagenta")}.");
            Console.ResetColor();

            Console.WriteLine($"This is {DarkGray("DarkGray")}.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"This is {("DarkGray")}.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

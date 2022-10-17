using System;

namespace C1_The_Defense_Of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            Console.Write("Target Row? ");
            string rowStringInput = Console.ReadLine();
            Console.Write("Target Column? ");
            string columnStringInput = Console.ReadLine();

            int row = Convert.ToInt32(rowStringInput);
            int column = Convert.ToInt32(columnStringInput);

            /*
             * These calculations does not use corrections for negative coordinates
             * i.e. (-1, 0)
             */

            int leftSideRow = row;
            int leftSideColumn = column - 1;

            int topSideRow = row + 1;
            int topSideColumn = column;

            int rightSideRow = row;
            int rightSideColumn = column + 1;

            int bottomSideRow = row - 1;
            int bottomSideColumn = column;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Left Side: ({leftSideRow},{leftSideColumn})");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Top Side: ({topSideRow},{topSideColumn})");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Right Side: ({rightSideRow},{rightSideColumn})");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Bottom Side: ({bottomSideRow},{bottomSideColumn})");

            Console.Beep();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
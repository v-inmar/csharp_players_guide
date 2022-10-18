using System;

namespace C1_Repairing_The_Clocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string numberString = Console.ReadLine();

            int number = Convert.ToInt32(numberString);

            bool isEven = number % 2 == 0;

            if (isEven) Console.WriteLine("Tick");
            else Console.WriteLine("Tock");
        }
    }
}
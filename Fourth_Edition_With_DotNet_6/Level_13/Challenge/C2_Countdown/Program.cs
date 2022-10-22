using System;

namespace C2_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Countdown(10);
        }

        /// <summary>
        /// Recursively display the numbers
        /// </summary>
        /// <param name="number">The base case where the countdown begins</param>
        static void Countdown(int number)
        {
            if(number == 0) return;
            Console.WriteLine(number);
            Countdown(number - 1);
        }
    }
}
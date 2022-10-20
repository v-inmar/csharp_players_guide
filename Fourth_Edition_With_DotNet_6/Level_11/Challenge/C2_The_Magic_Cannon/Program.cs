using System;

namespace C2_The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fire and Electric");
                    Console.ResetColor();
                }else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire");
                    Console.ResetColor();
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Normal");
                }



            }
            
        }
    }
}
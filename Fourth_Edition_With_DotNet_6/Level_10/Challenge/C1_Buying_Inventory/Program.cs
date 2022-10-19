using System;

namespace C1_Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");

            Console.Write("What number do you want to see the price of? ");

            // Careful with user input. It must be convertable to int
            // for now this is ok
            int choice = Convert.ToInt32(Console.ReadLine());


            string response = choice switch
            {
                1 => $"Rope cost 10 gold",
                2 => $"Torches cost 15 gold",
                3 => $"Climbing Equipment cost 25 gold",
                4 => $"Clean Water cost 1 gold",
                5 => $"Machete cost 20 gold",
                6 => $"Canoe cost 200 gold",
                7 => $"Food Supplies cost 1 gold",
                _ => $"Item not available"
            };

            Console.WriteLine(response);


        }
    }
}
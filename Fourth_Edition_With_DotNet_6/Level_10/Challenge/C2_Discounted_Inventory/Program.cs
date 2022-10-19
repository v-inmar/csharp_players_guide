using System;

namespace C2_Discounted_Inventory
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
            if (choice > 7 || choice < 1)
            {
                Console.WriteLine("The item does not exist. Please only choose from what is available");
            }
            else
            {
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                string item = "";
                int value = 0;
                switch (choice)
                {
                    case 1:
                        item = "Rope";
                        value = 10;
                        break;
                    case 2:
                        item = "Torches";
                        value = 15;
                        break;
                    case 3:
                        item = "Climbing Equipment";
                        value = 25;
                        break;
                    case 4:
                        item = "Clean Water";
                        value = 1;
                        break;
                    case 5:
                        item = "Machete";
                        value = 20;
                        break;
                    case 6:
                        item = "Canoe";
                        value = 200;
                        break;
                    case 7:
                        item = "Food Supplies";
                        value = 1;
                        break;
                    default:
                        break;

                }

                string response = name == "Vin" ? $"{item} cost {value / 2.0:##.##} gold" : $"{item} cost {value} gold";
                Console.WriteLine(response);

            }
        }
    }
}
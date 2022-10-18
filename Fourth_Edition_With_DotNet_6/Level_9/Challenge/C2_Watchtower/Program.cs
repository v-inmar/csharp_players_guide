using System;

namespace C2_Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the x value: ");
            string xString = Console.ReadLine();
            Console.Write("Enter the y value: ");
            string yString = Console.ReadLine();

            int xValue = Convert.ToInt32(xString);
            int yValue = Convert.ToInt32(yString);
            string message = "The enemy is to the ";

            if (xValue < 0 && yValue > 0) message += "northwest";
            if (xValue < 0 && yValue == 0) message += "west";
            if (xValue < 0 && yValue < 0) message += "southwest";
            if (xValue == 0 && yValue > 0) message += "north";
            if (xValue == 0 && yValue < 0) message += "south";
            if (xValue > 0 && yValue > 0) message += "northeast";
            if (xValue > 0 && yValue == 0) message += "east";
            if (xValue > 0 && yValue < 0) message += "southeast";

            string toDisplay = xValue == 0 && yValue == 0 ? "The enemy is here!" : message;

            Console.WriteLine(toDisplay);
        }
    }
}
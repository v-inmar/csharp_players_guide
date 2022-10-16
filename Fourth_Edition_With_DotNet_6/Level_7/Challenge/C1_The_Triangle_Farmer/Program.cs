using System;

namespace C1_The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note: Can be extended to check for invalid inputs such as inputs that are not number.
            // Note: Also, look out for empty entries or voids
            Console.Write("Enter the value for height: ");
            string heightString = Console.ReadLine();
            Console.Write("Enter the value for base: ");
            string baseString = Console.ReadLine();

            double area = (Double.Parse(heightString) * Double.Parse(baseString)) / 2;
            Console.WriteLine("The area of the triangle is " + area);
        }
    }
}
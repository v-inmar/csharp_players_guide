using System;


namespace C3_The_Dominion_Of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * estate is 1 point
             * ducky is 3 points
             * province is 6 points
             */

            Console.Write("Enter the number of Estates: ");
            string numberOfEstates = Console.ReadLine();
            Console.Write("Enter the number of Duchies: ");
            string numberOfDuchies = Console.ReadLine();
            Console.Write("Enter the number of Provinces: ");
            string numberOfProvinces = Console.ReadLine();
            
            int totalPoints = Convert.ToInt32(numberOfEstates) + (Convert.ToInt32(numberOfDuchies)* 3) + (Convert.ToInt32(numberOfProvinces)* 6);
            Console.WriteLine("The total points for the user is: " + totalPoints);
        }
    }
}
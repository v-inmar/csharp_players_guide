using System;

namespace C1_The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputArray = new int[5];
            
            // User insert array values
            for(int i = 0; i < userInputArray.Length; i++)
            {
                Console.Write($"Enter a number for index {i}: ");
                userInputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Copy array value into new array
            int[] copyArray = new int[userInputArray.Length];
            for(int i = 0; i < userInputArray.Length; i++)
            {
                copyArray[i] = userInputArray[i];
            }

            // Display value of both array one index at a time
            for(int i = 0; i < userInputArray.Length; i++)
            {
                Console.WriteLine($"User Input Array on index: {i} has a value of {userInputArray[i]}");
                Console.WriteLine($"Copy Array on index: {i} has a value of {copyArray[i]}");
            }

            


        }
    }
}
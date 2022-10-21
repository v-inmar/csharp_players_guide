using System;

namespace C2_The_Laws_Of_Freach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4,51,-7,13,-99,15,-8,45,90};
            int total = 0;
            foreach(int item in array)
            {
                total += item;
            }

            float average = (float)total / array.Length;
            Console.WriteLine(average);
        }
    }
}
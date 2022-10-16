using System;
using System.Collections.Generic;

namespace C2_The_Four_Sisters_And_The_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of eggs: ");
            string numberOfEggs = Console.ReadLine();
            int remainder = Int32.Parse(numberOfEggs) % 4;
            int eggsPerSister = (Int32.Parse(numberOfEggs) - remainder) / 4;

            Console.WriteLine("Each sister gets " + eggsPerSister + " eggs each and the Duckbear gets " + remainder + " eggs");

        }
    }
}

/*
 * QUESTION
 * What are three total egg counts where the duckbear get more than each sister does?
 * 
 * ANSWER
 * 6, 7, 11
 * 
 * 6 total egg(s) - Sisters get 1 egg(s) each and Duckbear gets 2
 * 7 total egg(s) - Sisters get 1 egg(s) each and Duckbear gets 3
 * 11 totla egg(s) - Sisters get 2 egg(s) each and Duckbear get 3
 * 
*/

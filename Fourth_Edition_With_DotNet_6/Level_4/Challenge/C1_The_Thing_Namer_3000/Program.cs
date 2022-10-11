using System;

namespace C1_The_Thing_Namer_3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine(); // Stores the name of the thing
            Console.WriteLine("How would you describe it? Big? Azure? Tattered");
            string b = Console.ReadLine(); // Stores the description of the thing
            string c = "Doom"; // Added text 
            string d = "3000"; // More added text
            Console.WriteLine("The "+ b + " " + a + " of " + c + " " + d + "!");
        }
    }
}

// Question
// Aside from cpmments, what is one other thing you could do to make this code more understandable?

// Answer
// Use meaningful words as variable names such as 'name' or 'description'.

// Added Bonus Answer
// Variables c and d can be combined into a single constant variable since the values they hold does not change overtime.



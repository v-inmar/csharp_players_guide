using System;

namespace C1_The_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber;
            while(true)
            {
                Console.Write("Pilot please enter a number: ");
                string secretNumberString = Console.ReadLine();
                secretNumber = Convert.ToInt32(secretNumberString);

                // Make sure secret number is within the range
                if (secretNumber < 0 || secretNumber > 100)
                    Console.WriteLine("Only numbers between 0 - 100");
                else
                    break;
            }
            Console.Clear();

            
            while(true)
            {
                Console.Write("Hunter, what is the Pilot's number: ");
                string guessedNumberString = Console.ReadLine();
                int guessedNumber = Convert.ToInt32(guessedNumberString);

                // Make sure guess is in range. Maybe not so ideal but ok for this
                if(guessedNumber < 0 || guessedNumber > 100)
                {
                    Console.WriteLine("Only numbers between 0 - 100");
                    continue;
                }

                // Check guess with secret
                if(guessedNumber < secretNumber)
                {
                    Console.WriteLine("Your guess is too low");
                }else if(guessedNumber > secretNumber)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Hunter, you correctly guessed the Pilot's number: {secretNumber}");

        }
    }
}
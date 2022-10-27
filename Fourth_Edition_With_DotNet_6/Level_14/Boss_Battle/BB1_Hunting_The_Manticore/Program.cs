using System;

namespace BB1_Hunting_The_Manticore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare know variables
            int round = 1;
            int cityHealth, cityHealthMax;
            cityHealth = cityHealthMax = 15;
            int manticoreHealth, manticoreHealthMax;
            manticoreHealth = manticoreHealthMax = 10;

            int manticoreDistance = GetUserInput("Manticore distance (0-100): ");
            int cannonRange;
            Console.Clear();
            
            // Infinite loop
            // This can be inside another function
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                DisplayStatus(round, cityHealth, cityHealthMax, manticoreHealth, manticoreHealthMax);
                int damage = GetDamage(round);
                DisplayCannonDamage(damage);
                cannonRange = GetUserInput("Enter desired cannon range: ");
                if(manticoreDistance < cannonRange)
                {
                    Console.WriteLine("Missle overshot");
                    cityHealth -= 1;
                    round++;
                }else if(manticoreDistance > cannonRange)
                {
                    Console.WriteLine("Missle fell short");
                    cityHealth -= 1;
                    round++;
                }
                else
                {
                    Console.WriteLine("DIRECT HIT!");
                    cityHealth -= 1;
                    round++;
                    manticoreHealth -= damage;
                }

                if(cityHealth <= 0)
                {
                    Console.WriteLine("The City has been destroyed!");
                    break;
                }

                if(manticoreHealth <= 0)
                {
                    Console.WriteLine("The Manticore has been destroyed! The City of Consolas has been saved!");
                    break;
                }
            }


        }

        /// <summary>
        /// Displat the status message about the round, and healths
        /// </summary>
        /// <param name="round">The current round</param>
        /// <param name="cityHealth">The current health of the city</param>
        /// <param name="cityHealthMax">The maximum health of the city</param>
        /// <param name="manticoreHealth">The current health of the manticore</param>
        /// <param name="manticoreHealthMax">The maximum health of the manticore</param>
        static void DisplayStatus(int round, int cityHealth, int cityHealthMax, int manticoreHealth, int manticoreHealthMax)
        {
            Console.WriteLine($"STATUS: Round: {round}\t City: {cityHealth}\\{cityHealthMax}\t Manticore: {manticoreHealth}\\{manticoreHealthMax}");
        }


        /// <summary>
        /// Display the damage number for the round
        /// </summary>
        /// <param name="damage">The current damage</param>
        static void DisplayCannonDamage(int damage)
        {
            
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
            Console.ResetColor();
        }

        /// <summary>
        /// Ask user to enter a number
        /// </summary>
        /// <param name="message">Display message to the user</param>
        /// <returns>32bit integer</returns>
        static int GetUserInput(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }



        /// <summary>
        /// Checks if round is multiple of three
        /// </summary>
        /// <param name="round">The current value integer of round</param>
        /// <returns>Boolean</returns>
        static bool IsMultipleOfThree(int round)
        {
            if(round % 3 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if round is multiple of five
        /// </summary>
        /// <param name="round">The current value integer of round</param>
        /// <returns>Boolean</returns>
        static bool IsMultipleOfFive(int round)
        {
            if (round % 5 == 0)
            {
                return true;
            }
            return false;
        }



        /// <summary>
        /// Determines the damage and colour of the text depending on the round number
        /// </summary>
        /// <param name="round">The current integer value for the round</param>
        /// <returns>32bit Integer</returns>
        static int GetDamage(int round)
        {
            Console.ResetColor();
            if(IsMultipleOfFive(round) && IsMultipleOfThree(round)){
                Console.ForegroundColor = ConsoleColor.Blue;
                return 10;
            }else if (IsMultipleOfThree(round))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return 3;
            }else if (IsMultipleOfFive(round))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return 3;
            }
            else
            {
                return 1;
            }
        }


        
    }
}
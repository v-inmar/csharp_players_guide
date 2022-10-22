namespace C1_Taking_A_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = AskForNumber("Enter a number");
            Console.WriteLine(firstNumber);

            int rangeNumber = AskForNumberInRange("Enter a number between 0 and 100", 0, 100);
            Console.WriteLine(rangeNumber);
        }

        /// <summary>
        /// Ask for a number
        /// </summary>
        /// <param name="text">Display message for asking user a number</param>
        /// <returns>A 32 bit integer</returns>
        static int AskForNumber(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Ask for a number between the range of min and max
        /// </summary>
        /// <param name="text">Display message for asking user a number</param>
        /// <param name="min">The floor of the range</param>
        /// <param name="max">The ceiling of the range</param>
        /// <returns>A 32 bit integer</returns>
        static int AskForNumberInRange(string text, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(text);
                int value = Convert.ToInt32(Console.ReadLine());
                if(value < min)
                {
                    Console.WriteLine("Number entered is too low");
                    continue;
                }

                if(value > max)
                {
                    Console.WriteLine("Number entered is too high");
                    continue;
                }

                return value;
            }
        }
    }


    // Candidate challenge that can use this is the challenge called The Prototype on Level 11
}
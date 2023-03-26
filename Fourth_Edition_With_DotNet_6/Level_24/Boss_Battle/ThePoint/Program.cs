namespace ThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ***** The Point: 75XP ***** */
            Console.WriteLine();
            Console.WriteLine("- ----- The Point ----- -");
            Point one = new(x: 2, y: 3);
            Point two = new(x: -4, y: 0);
            Console.WriteLine($"Point {nameof(one)} has the coodinates ({one.X}, {one.Y})");
            Console.WriteLine($"Point {nameof(two)} has the coodinates ({two.X}, {two.Y})");
            /*
             * Question: Are your X and Y properties immutable? Why did you choose what you did?
             * 
             * Answer:
             * The X and Y properties are mutable (not immutable) so it can change overtime.
             * They are also public so they can be accessed outside the of the Point instance for displaying
             */




            /* ***** The Color: 100XP ***** */
            Console.WriteLine();
            Console.WriteLine("- ----- The Color ----- -");
            Color pink = new(r: 255, g: 192, b: 203);
            Color purple = Color.Purple;
            Console.WriteLine($"Color {nameof(pink)} has channel values (red={pink.R}, green={pink.G}, blue={pink.B})");
            Console.WriteLine($"Color {nameof(purple)} has channel values (red={purple.R}, green={purple.G}, blue={purple.B})");


            /* ***** The Card: 100XP ***** */
            Console.WriteLine();
            Console.WriteLine("- ----- The Card ----- -");
            foreach (Enums.CardColor color in Enum.GetValues<Enums.CardColor>())
            {
                foreach (Enums.CardRank rank in Enum.GetValues<Enums.CardRank>())
                {
                    Card card = new() { Color = color, Rank = rank };
                    Console.WriteLine($"The {card.Color} {card.Rank} is a {card.GetCardType}");
                }
            }

            /*
             * Question: Why do you think we used a color enumeration here, but in the previous challenge, we made a color class?
             * 
             * Answer:
             * I think the reason for using enumeration for the color is to restrict the amount of available colors.
             * It also allows creating the different string colors and loop through without having to create a list or array of colors.
             * If we use the class Color, we would have made an array of color instances
             * 
             * I think...
             */


            /* ***** The Locked Door: 100XP ***** */
            Console.WriteLine();
            Console.WriteLine("- ----- The Locked Door (Currently Commented Out For The Below Codes To Execute) ----- -");
            //Console.WriteLine("Enter a starting passcode: ");
            //string? startingPasscode = Console.ReadLine();
            //if(startingPasscode == null)
            //{
            //    Console.WriteLine("Program exited.");
            //    return;
            //}
            //Door door = new(passcode: startingPasscode);
            //Console.WriteLine("New Door is created!");
            //while (true)
            //{
            //    Console.WriteLine("Enter the number of what you want to do (0: Exit, 1: Change Passcode, 2: Set Door State): ");
            //    string userAction = Console.ReadLine() ?? "0";
            //    switch (userAction)
            //    {
            //        case "0":
            //            goto default;
            //        case "1":
            //            door.SetNewPasscode();
            //            break;
            //        case "2":
            //            door.SetDoorState();
            //            break;
            //        default:
            //            Console.WriteLine("Program Exited");
            //            return;
            //    }
            //}



            /* ***** The Locked Door: 100XP ***** */
            Console.WriteLine();
            Console.WriteLine("- ----- The Password Validator ----- -");

            while (true)
            {
                Console.WriteLine("Enter a password: ");
                string password = Console.ReadLine() ?? "";

                // PasswordValidator is static, hence no instance is created.
                // It is more of a global utility rather than a data structure
                if (PasswordValidator.IsPassowrdValid(password))
                {
                    Console.WriteLine("Password is Valid!");
                }
                else
                {
                    Console.WriteLine("Password is NOT Valid!");
                }
            }

        }


        
    }
}


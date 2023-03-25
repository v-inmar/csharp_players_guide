namespace ThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ***** The Point: 75XP ***** */
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
            Color pink = new(r: 255, g: 192, b: 203);
            Color purple = Color.Purple;
            Console.WriteLine($"Color {nameof(pink)} has channel values (red={pink.R}, green={pink.G}, blue={pink.B})");
            Console.WriteLine($"Color {nameof(purple)} has channel values (red={purple.R}, green={purple.G}, blue={purple.B})");


            /* ***** The Card: 100XP ***** */
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
        }
    }
}


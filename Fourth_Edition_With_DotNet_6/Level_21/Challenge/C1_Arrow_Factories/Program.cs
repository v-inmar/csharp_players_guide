using System;

namespace C1_Arrow_Factories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow; // Create an arrow variable

            Console.Write("Enter predefined or custom: ");
            string arrowCraftChoice = Console.ReadLine();

            // It can only be predefined or custom
            // invalid choice will default to custom
            if(arrowCraftChoice == "predefined")
            {
                Console.WriteLine("Please enter number of chosen arrow");
                Console.WriteLine("1. Elite Arrow");
                Console.WriteLine("2. Beginner Arrow");
                Console.WriteLine("3. Marksman Arrow");

                string predefinedChoice = Console.ReadLine();

                // invalid choice will default to beginner arrow
                arrow = predefinedChoice switch
                {
                    "1" => Arrow.CreateEliteArrow,
                    "2" => Arrow.CreateBeginnerArrow,
                    "3" => Arrow.CreateMarksmanArrow,
                    _ => Arrow.CreateBeginnerArrow
                };

            }
            else
            {
                Console.Write($"Enter arrowhead ({GetArrowheadStringNames()}): ");
                Arrowhead arrowhead = GetArrowheadFromString(Console.ReadLine());
                Console.Write($"Enter fletching ({GetFletchingStringNames()}): ");
                Fletching fletching = GetFletchingFromString(Console.ReadLine());
                Console.Write("Enter shaft length (60 - 100): ");
                int shaftLength = Convert.ToInt32(Console.ReadLine()); // Future: Can apply some checking mechanism with default value
                arrow = new() { Arrowhead = arrowhead, Fletching = fletching, ShaftLength = shaftLength };
            }
            

            // Change the instance creation since constructor does not exist anymore
            //Arrow arrow = new() { Arrowhead = arrowhead, Fletching = fletching, ShaftLength = shaftLength };


            Console.WriteLine($"Arrow(head: {arrow.Arrowhead}, fletching: {arrow.Fletching}, length: {arrow.ShaftLength}) cost: {arrow.Cost:0.00}");
        }

        /// <summary>
        /// Get all the names of the arrowhead enum values as a single string
        /// </summary>
        /// <returns>string</returns>
        static string GetArrowheadStringNames()
        {
            string response = "";
            foreach (string item in Enum.GetNames(typeof(Arrowhead)))
            {
                response += $"{item},";
            }
            return response;
        }

        /// <summary>
        /// Get all the names of the fletching enum values as a single string
        /// </summary>
        /// <returns>string</returns>
        static string GetFletchingStringNames()
        {
            string response = "";
            foreach (string item in Enum.GetNames(typeof(Fletching)))
            {
                response += $"{item},";
            }
            return response;
        }

        /// <summary>
        /// Get Arrowhead depending on the string
        /// </summary>
        /// <param name="arrowhead">string</param>
        /// <returns>Arrowhead enum</returns>
        static Arrowhead GetArrowheadFromString(string arrowhead)
        {

            return arrowhead switch
            {
                "Steel" => Arrowhead.Steel,
                "Obsidian" => Arrowhead.Obsidian,
                _ => Arrowhead.Wood // Makes Wood default (cheapest)
            };
        }

        /// <summary>
        /// Get Fletching depending on the string
        /// </summary>
        /// <param name="fletching">string</param>
        /// <returns>Fletching enum</returns>
        static Fletching GetFletchingFromString(string fletching)
        {
            return fletching switch
            {
                "Plastic" => Fletching.Plastic,
                "Turkey" => Fletching.Turkey,
                _ => Fletching.Goose // Makes Goose default (cheapest)
            };
        }

        /// <summary>
        /// Represents arrow that contains Arrowhead, Fletching and Shaft length data
        /// </summary>
        class Arrow
        {

            // Properties of the fields
            // init accessor is used since fields don't change values once selected
            public Arrowhead Arrowhead { get; init; }
            public Fletching Fletching { get; init; }
            public int ShaftLength { get; init; }

            // Static fields for making pre-defined arrows
            public static Arrow CreateEliteArrow => new() { Arrowhead = Arrowhead.Steel, Fletching = Fletching.Plastic, ShaftLength = 95 };
            public static Arrow CreateBeginnerArrow => new() { Arrowhead = Arrowhead.Wood, Fletching = Fletching.Goose, ShaftLength = 75 };
            public static Arrow CreateMarksmanArrow => new() { Arrowhead = Arrowhead.Steel, Fletching = Fletching.Goose, ShaftLength = 65 };

            /// <summary>
            /// Property: Gets the total cost of the arrow depending on the arrow head, fletching and length
            /// </summary>
            /// <returns>float</returns>
            public float Cost
            {
                get
                {
                    float arrowheadCost;
                    float fletchingCost;
                    float shaftLengthCost = (float)this.ShaftLength * 0.005f;

                    arrowheadCost = this.Arrowhead switch
                    {
                        Arrowhead.Steel => 10f,
                        Arrowhead.Obsidian => 5f,
                        Arrowhead.Wood => 3f,
                        _ => 3f // Wood is default (cheapest)
                    };

                    fletchingCost = this.Fletching switch
                    {
                        Fletching.Plastic => 10f,
                        Fletching.Turkey => 5f,
                        _ => 3f // Goose is default (cheapest)
                    };

                    return arrowheadCost + fletchingCost + shaftLengthCost;
                }
            }





        }

        enum Arrowhead { Steel, Wood, Obsidian };
        enum Fletching { Plastic, Turkey, Goose };
    }
}
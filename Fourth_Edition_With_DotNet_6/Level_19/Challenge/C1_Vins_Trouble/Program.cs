using System;

namespace C1_Vins_Trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter arrowhead ({GetArrowheadStringNames()}): ");
            Arrowhead arrowhead = GetArrowheadFromString(Console.ReadLine());
            Console.Write($"Enter fletching ({GetFletchingStringNames()}): ");
            Fletching fletching = GetFletchingFromString(Console.ReadLine());
            Console.Write("Enter shaft length (60 - 100): ");
            int shaftLength = Convert.ToInt32(Console.ReadLine()); // Future: Can apply some checking mechanism with default value

            Arrow arrow = new(arrowhead, fletching, shaftLength);

            Console.WriteLine($"Arrow(head: {arrowhead}, fletching: {fletching}, length: {shaftLength}) cost: {arrow.GetCost():0.00}");
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
            private Arrowhead arrowhead;
            private Fletching fletching;
            private int shaftLength;

            public Arrow(Arrowhead arrowhead, Fletching fletching, int shaftLength)
            {
                this.arrowhead = arrowhead;
                this.fletching = fletching;
                this.shaftLength = shaftLength;
            }

            // Getters
            public Arrowhead GetArrowhead() => this.arrowhead;
            public Fletching GetFletching() => this.fletching;
            public int GetShaftLength() => this.shaftLength;

            // Setters
            public void SetArrowhead(Arrowhead arrowhead) => this.arrowhead = arrowhead;
            public void SetFletching(Fletching fletching) => this.fletching = fletching;
            public void SetShaftLength(int shaftLength) => this.shaftLength = shaftLength;

            /// <summary>
            /// Gets the total cost of the arrow depending on the arrow head, fletching and length
            /// </summary>
            /// <returns>float</returns>
            public float GetCost()
            {
                float arrowheadCost;
                float fletchingCost;
                float shaftLengthCost = (float)this.shaftLength * 0.005f;

                arrowheadCost = this.arrowhead switch
                {
                    Arrowhead.Steel => 10f,
                    Arrowhead.Obsidian => 5f,
                    Arrowhead.Wood => 3f,
                    _ => 3f // Wood is default (cheapest)
                };

                fletchingCost = this.fletching switch
                {
                    Fletching.Plastic => 10f,
                    Fletching.Turkey => 5f,
                    _ => 3f // Goose is default (cheapest)
                };

                return arrowheadCost + fletchingCost + shaftLengthCost;

            }


        }

        enum Arrowhead { Steel, Wood, Obsidian };
        enum Fletching { Plastic, Turkey, Goose };
    }
}
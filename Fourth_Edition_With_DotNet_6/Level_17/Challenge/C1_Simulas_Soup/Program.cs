using System;

namespace C1_Simulas_Soup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            (Type FoodType, Ingredient FoodIngredient, Seasoning FoodSeasoning)[] food = new (Type, Ingredient, Seasoning)[3];

            
            // Foreach cannot be used here since foreach create a scoped variable that cannot be changed
            for(int i = 0; i < food.Length; i++)
            {
                Console.Write($"What is the type? Only enter one from this list [{Type.Soup}, {Type.Gumbo}. {Type.Stew}]: ");
                Type foodType = DetermineType(Console.ReadLine());
                Console.Write($"What is the main ingredient? Only enter one from this list [{Ingredient.Mushrooms}, {Ingredient.Potatoes}, {Ingredient.Chicken}, {Ingredient.Carrots}]: ");
                Ingredient ingredient = DetermineIngredient(Console.ReadLine());
                Console.Write($"What is the seasoning? Only enter one from this list [{Seasoning.Spicy}, {Seasoning.Salty}, {Seasoning.Sweet}]: ");
                Seasoning seasoning = DetermineSeasoning(Console.ReadLine());

                food[i] = (foodType, ingredient, seasoning);
            }

            foreach(var singleFood in food)
            {
                DisplayFood(singleFood);
            }
        }

        /// <summary>
        /// Displays the food with its associated features
        /// </summary>
        /// <param name="food">Tuple (Type, Ingredient, Seasoning)</param>
        static void DisplayFood((Type foodType, Ingredient foodIngredient, Seasoning foodSeasoning) food)
        {
            Console.WriteLine($"{food.foodSeasoning} {food.foodIngredient} {food.foodType}");
        }

        /// <summary>
        /// Determines which enum Type value matches the string
        /// </summary>
        /// <param name="foodtype">String</param>
        /// <returns>Type enum value</returns>
        static Type DetermineType(string foodtype)
        {
            return foodtype switch
            {
                "Stew" => Type.Stew,
                "Gumbo" => Type.Gumbo,
                _ => Type.Soup // defaults to soup
            };
        }

        /// <summary>
        /// Determines which enum Ingredient value matches string
        /// </summary>
        /// <param name="ingredient">String</param>
        /// <returns>Ingredient enum value</returns>
        static Ingredient DetermineIngredient(string ingredient)
        {
            return ingredient switch
            {
                "Mushrooms" => Ingredient.Mushrooms,
                "Chicken" => Ingredient.Chicken,
                "Carrots" => Ingredient.Carrots,
                _ => Ingredient.Potatoes // defaults to potatoes
            };
        }

        /// <summary>
        /// Determines which enum Seasoning value matches the string
        /// </summary>
        /// <param name="seasoning">String</param>
        /// <returns>Seasoning enum value</returns>
        static Seasoning DetermineSeasoning(string seasoning)
        {
            return seasoning switch
            {
                "Spicy" => Seasoning.Spicy,
                "Salty" => Seasoning.Salty,
                _ => Seasoning.Sweet // defaults to sweet
            };
        }

        enum Type { Soup, Stew, Gumbo};
        enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes };
        enum Seasoning { Spicy, Salty, Sweet };
    }
}
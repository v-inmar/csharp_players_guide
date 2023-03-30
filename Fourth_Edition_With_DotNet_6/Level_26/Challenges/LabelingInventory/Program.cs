namespace LaeblingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new(15.0, 10.0, 5);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine($"Items: {pack.CurrentNumberOfItems}/{pack.MaxNumberOfItems}\t Weight: {pack.CurrentWeight}/{pack.MaxWeight}\tVolume: {pack.CurrentVolume}/{pack.MaxVolume}");
                Console.WriteLine($"Contents: {pack.ToString()}");
                Console.WriteLine("What item would you like to add?");
                Console.WriteLine("1. Arrow\n2. Bow\n3. Rope\n4. Water\n5. Food\n6. Sword\n0. Exit Menu");
                Console.Write("Please enter the number: ");
                string choice = Console.ReadLine() ?? "0";

                if (choice == "0")
                {
                    exit = true;
                    continue;
                }

                InventoryItem? item = null;
                string? itemName = null;
                switch (choice)
                {
                    case "0":
                        goto default;
                    case "1":
                        item = new Arrow();
                        itemName = "Arrow";
                        break;
                    case "2":
                        item = new Bow();
                        itemName = "Bow";
                        break;
                    case "3":
                        item = new Rope();
                        itemName = "Rope";
                        break;
                    case "4":
                        item = new Water();
                        itemName = "Water";
                        break;
                    case "5":
                        item = new Food();
                        itemName = "Food";
                        break;
                    case "6":
                        item = new Sword();
                        itemName = "Sword";
                        break;
                    default:
                        Console.WriteLine("Item not recognized");
                        break;

                }

                if (item != null)
                {
                    if (pack.Add(item))
                    {
                        Console.WriteLine($"New Item: {itemName} added");
                    }
                    else
                    {
                        Console.WriteLine($"New Item: {itemName} cannot be added");
                    }
                }
            }
        }
    }
}
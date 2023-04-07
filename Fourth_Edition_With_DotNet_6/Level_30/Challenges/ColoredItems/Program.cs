namespace ColoredItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorItem<Sword> swordItem = new(ConsoleColor.Red, new Sword());
            ColorItem<Bow> bowItem = new(ConsoleColor.Blue, new Bow());
            ColorItem<Axe> axeItem = new(ConsoleColor.Yellow, new Axe());

            swordItem.Display();
            bowItem.Display();
            axeItem.Display();
        }
    }
}
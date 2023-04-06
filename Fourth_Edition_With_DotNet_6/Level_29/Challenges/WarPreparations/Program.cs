namespace WarPreparations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword original = new(Enums.MaterialType.Iron, Enums.GemstoneType.None, 1, 1);

            Sword firstSword = original with { Material = Enums.MaterialType.Steel, Gemstone = Enums.GemstoneType.Diamond, Length = 10 };
            Sword secondSword = original with { Material = Enums.MaterialType.Binarium, Gemstone = Enums.GemstoneType.Bitstone, Length = 15, CrossguardWidth = 3 };

            Console.WriteLine(original);
            Console.WriteLine(firstSword);
            Console.WriteLine(secondSword);
        }
    }
}
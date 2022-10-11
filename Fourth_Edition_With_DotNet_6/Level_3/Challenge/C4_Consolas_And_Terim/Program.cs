
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        string name = Console.ReadLine(); // This can throw null error hence the warning
        Console.WriteLine("Noted: "+name+" got the bread.");
    }
}
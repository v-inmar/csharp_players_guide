using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredItems
{
    public class ColorItem<T> where T : IItem // Contrainted to objects that implements IItem interface
    {
        public ConsoleColor Color { get; set; }
        public T Item { get; set; }

        public ColorItem(ConsoleColor color, T item)
        {
            Color = color;
            Item = item;
        }

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Item);
        }
    }
}

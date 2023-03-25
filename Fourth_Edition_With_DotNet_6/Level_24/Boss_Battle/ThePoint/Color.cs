using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    class Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static Color White => new(r: 255, g: 255, b: 255);
        public static Color Black => new(r: 0, g: 0, b: 0);
        public static Color Red => new(r: 255, g: 0, b: 0);
        public static Color Orange => new(r: 255, g: 165, b: 0);
        public static Color Yellow => new(r: 255, g: 255, b: 0);
        public static Color Green => new(r: 0, g: 255, b: 0);
        public static Color Blue => new(r: 0, g: 0, b: 255);
        public static Color Purple => new(r: 128, g: 0, b: 128);
    }
}

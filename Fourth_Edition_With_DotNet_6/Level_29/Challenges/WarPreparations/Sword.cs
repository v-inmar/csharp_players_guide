using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarPreparations
{
    public record Sword(Enums.MaterialType Material, Enums.GemstoneType Gemstone, int Length, int CrossguardWidth);
}

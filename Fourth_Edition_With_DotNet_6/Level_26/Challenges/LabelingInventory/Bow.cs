using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    class Bow : InventoryItem
    {
        public Bow() : base(weight: 1, volume: 4)
        {
        }

        public override string ToString() => "Bow";
    }
}

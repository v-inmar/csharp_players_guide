using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    internal class Food : InventoryItem
    {
        public Food() : base(weight: 1, volume: 0.5)
        {
        }

        public override string ToString() => "Food";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    internal class Water : InventoryItem
    {
        public Water() : base(weight: 2, volume: 3)
        {
        }

        public override string ToString() => "Water";
    }
}

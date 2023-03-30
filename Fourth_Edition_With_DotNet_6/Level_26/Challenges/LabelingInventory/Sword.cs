using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    internal class Sword : InventoryItem
    {
        public Sword() : base(weight: 5, volume: 3)
        {
        }

        public override string ToString() => "Sword";
    }
}

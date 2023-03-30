using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    class Arrow : InventoryItem
    {
        public Arrow() : base(weight: 0.1, volume: 0.05){}

        public override string ToString() => "Arrow";
    }
}

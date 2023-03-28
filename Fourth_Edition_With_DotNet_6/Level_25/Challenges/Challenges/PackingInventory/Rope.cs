using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Rope : InventoryItem
    {
        public Rope() : base(weight: 1, volume: 1.5)
        {
        }
    }
}

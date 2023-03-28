using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    class Bow : InventoryItem
    {
        public Bow() : base(weight: 1, volume: 4)
        {
        }
    }
}

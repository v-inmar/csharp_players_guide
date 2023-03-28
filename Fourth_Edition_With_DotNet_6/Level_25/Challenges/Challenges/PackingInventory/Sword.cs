using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Sword : InventoryItem
    {
        public Sword() : base(weight: 5, volume: 3)
        {
        }
    }
}

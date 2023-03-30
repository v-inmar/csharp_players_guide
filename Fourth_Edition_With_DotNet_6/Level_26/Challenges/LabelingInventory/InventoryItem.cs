using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaeblingInventory
{
    class InventoryItem
    {
        public double Weight { get; set; }
        public double Volume { get; set; }

        public InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}

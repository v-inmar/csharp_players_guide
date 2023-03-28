using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Pack
    {

        private double _maxWeight;
        private double _maxVolume;
        private InventoryItem[] _items;

        

        public Pack(double maximumWeight, double maximumVolume, int totalNumberOfItems)
        {
            _maxWeight = maximumWeight;
            _maxVolume = maximumVolume;
            _items = new InventoryItem[totalNumberOfItems];
        }

        /// <summary>
        /// Add an item into the Pack
        /// </summary>
        /// <param name="newItem">InventoryItem derived class instance</param>
        /// <returns>Boolean</returns>
        public bool Add(InventoryItem newItem)
        {
            for(int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == null)
                {
                    if ((GetTotalItemWeight() + newItem.Weight <= _maxWeight) && (GetTotalItemVolume() + newItem.Volume <= _maxVolume))
                    {
                        _items[i] = newItem;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }


        public double MaxWeight => _maxWeight;
        public double MaxVolume => _maxVolume;
        public int MaxNumberOfItems => _items.Length;
        public double CurrentWeight => GetTotalItemWeight();
        public double CurrentVolume => GetTotalItemVolume();
        public int CurrentNumberOfItems => GetTotalItemCount();

        /// <summary>
        /// Private: Get the total number of non-null items from the array 
        /// </summary>
        /// <returns>32bit Integer</returns>
        private int GetTotalItemCount()
        {
            int totalCount = 0;
            foreach(InventoryItem item in _items)
            {
                totalCount += item != null ? 1 : 0;
            }
            return totalCount;
        }

        /// <summary>
        /// Private: Get the current overall weight of all the non-null items in the array
        /// </summary>
        /// <returns>Double</returns>
        private double GetTotalItemWeight()
        {
            double totalWeight = 0;
            foreach(InventoryItem item in _items)
            {
                totalWeight += item?.Weight ?? 0.0; ;
            }
            return totalWeight;
        }

        /// <summary>
        /// Private: Get the current overall volume of all the non-null items in the array
        /// </summary>
        /// <returns>Double</returns>
        private double GetTotalItemVolume()
        {
            double totalVolume = 0;
            foreach (InventoryItem item in _items)
            {
                totalVolume += item?.Volume ?? 0.0;
            }
            return totalVolume;
        }
    }
}

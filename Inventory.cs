using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class Inventory
    {
        private int capacity;
        private Dictionary<int, ItemClass> inventory
            = new ();

        public Inventory() // base
        {
            Capacity = 0;
        }
        public Inventory(int capacity) => 
            inventory.EnsureCapacity(capacity);

        public ItemClass GetItem(int e)
        {
            return inventory[e];
        }

        public void PlaceItem(ItemClass v)
        {
            int ef = inventory.Count + 1;

            inventory.EnsureCapacity(++Capacity);
            inventory.Add(ef, v);
        }

        public int Capacity { get => capacity; set => capacity = value; }
    }
}

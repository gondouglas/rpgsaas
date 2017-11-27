using System.Collections.Generic;

namespace Entities
{
    public class Inventory
    {
        private List<ItemBase> inventory;

        public Inventory()
        {
            inventory = new List<ItemBase>();
        }

        public List<ItemBase> GetInventory()
        {
            return inventory;
        }

        public void SetInventory(List<ItemBase> value)
        {
            inventory = value;
        }
    }
}
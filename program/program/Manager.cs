using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Manager
    {
        private Inventory inventory;

        public Manager()
        {
            inventory = new Inventory();
        }

        public void AddItemToInventory(string itemName, int quantity)
        {
            inventory.AddItem(itemName, quantity);
            Console.WriteLine($"{quantity} {itemName}(s) added to inventory.");
        }

        public void RemoveItemFromInventory(string itemName, int quantity)
        {
            inventory.RemoveItem(itemName, quantity);
        }

        public void ViewInventory()
        {
            inventory.ViewInventoryItems();
        }
    }
}

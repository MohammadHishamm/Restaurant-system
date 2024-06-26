﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Manager
    {
        private Inventory inventory;
        private List<Menu> menus; 


        public Manager()
        {
            inventory = new Inventory();
            menus= new List<Menu>();


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

        public void AddMenuItemToMenu(Menu menu, MenuItem menuItem)
        {
            if (!menus.Contains(menu))
            {
                menus.Add(menu);
            }

            menu.AddMenuItem(menuItem);
            Console.WriteLine($"Added {menuItem.Title} to menu {menu.MenuID}.");
        }

        public void RemoveMenuItemFromMenu(Menu menu, MenuItem menuItem)
        {
            menu.RemoveMenuItem(menuItem);
            Console.WriteLine($"Removed {menuItem.Title} from menu {menu.MenuID}.");
        }

        public void ViewMenus()
        {
            foreach (var menu in menus)
            {
                menu.ViewMenu();
            }
        }


    }
}

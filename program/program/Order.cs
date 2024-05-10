using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Order
    {
        public int OrderID { get; private set; }
        public string Status { get; set; }
        private List<string> menuItems;

      
        public Order(int orderID, string status)
        {
            OrderID = orderID;
            Status = status;
            menuItems = new List<string>();
        }


        public void AddMenuItem(string menuItem)
        {
            menuItems.Add(menuItem);
        }

        public void RemoveMenuItem(string menuItem)
        {
            menuItems.Remove(menuItem);
        }
    }
}

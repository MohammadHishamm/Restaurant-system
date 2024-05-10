
using program;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Table table = new Table(10, "available", 5);

            //Reservation reservation = new Reservation(11, DateTime.Now, 6, 10);

            //reservation.CreateReservation();
            //table.AddReservation(reservation);
            //table.ViewReservations();
            //reservation.CancelReservation(table);
            //table.ViewReservations();
            //Manager manager = new Manager();
            //manager.AddItemToInventory("bread", 20);
            //manager.RemoveItemFromInventory("bread", 8);
            //manager.ViewInventory();

            //Inventory inventory = new Inventory();
            //inventory.AddItem("test", 100);
            //inventory.RemoveItem("test", 28);
            //inventory.ViewInventoryItems();


            //menuitem item1 =new menuitem(1,"item1","testest",120);
            //menuitem item2 = new menuitem(2, "item2", "testest", 150);
            //menuitem item3 = new menuitem(3, "item3", "testest", 520);
            //Menu menu = new Menu(1);
            //Menu menu2 = new Menu(2);
            //Manager manager = new Manager();    
            //manager.AddMenuItemToMenu(menu,item1);
            //manager.AddMenuItemToMenu(menu, item2);
            //manager.AddMenuItemToMenu(menu2, item3);
            //manager.ViewMenus();


            MenuItem item1 = new MenuItem(1, "item1", "testest", 120);
            MenuItem item2 = new MenuItem(2, "item2", "testest", 150);
            MenuItem item3 = new MenuItem(3, "item3", "testest", 520);

            Customer customer=new Customer("omar","0101010101",2);
            Waiter waiter = new Waiter();
            List<MenuItem> list = new List<MenuItem>();
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);

            customer.PlaceOrder(waiter, list);

         


















        }





    }
}

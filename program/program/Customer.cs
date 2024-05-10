using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Customer
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public int CustomerID { get; private set; }



        public Customer(string name, string contactNumber, int customerID)
        {
            Name = name;
            ContactNumber = contactNumber;
            CustomerID = customerID;
        }


        

    }
}

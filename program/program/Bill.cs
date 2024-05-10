using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Bill
    {
        public int BillID { get; private set; }
        public int CustomerID { get; private set; }
        public string PaymentType { get; set; }


        public Bill(int billID, int customerID, string paymentType)
        {
            BillID = billID;
            CustomerID = customerID;
            PaymentType = paymentType;
        }


        public void Pay()
        {

        }

        public void CancelPayment()
        {

        }
    }
}

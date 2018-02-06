using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Payment
    {
        //attributes
        private string receiptno;
        private DateTime date;
        private string items;
        private double amount;

        //creating property for each attribute
        public string ReceiptNo
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
        public string Items
        {
            get; set;
        }
        public double Amount
        {
            get; set;
        }

        //to make payment
        public void makePayment()
        {

        }
    }
}

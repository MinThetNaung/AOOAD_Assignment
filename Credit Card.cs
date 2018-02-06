using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Credit card is a sub class of Payment class
    class Credit_Card : Payment
    {
        public Credit_Card(string receiptno, DateTime date, string items, double amount)
        {
            ReceiptNo = receiptno;
            Date = date;
            Items = items;
            Amount = amount;
        }
    }
}

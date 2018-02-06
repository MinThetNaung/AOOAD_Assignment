using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Cheque is a sub-class of Payment class
    class Cheque : Payment
    {
        public Cheque(string receiptno, DateTime date, string items, double amount)
        {
            ReceiptNo = receiptno;
            Date = date;
            Items = items;
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Receipt
    {
        public string userName;
        public string userCreditNo;
        public string userCreditExpiry;
        public string userCreditCode;
        public string userCreditPin;
        public double userPayAmt;
        public string UserName
        {
            get; set;
        }
        public string UserCreditNo
        {
            get; set;
        }
        public string UserCreditExpiry
        {
            get; set;
        }
        public string UserCreditCode
        {
            get; set;
        }
        public string UserCreditPin
        {
            get; set;
        }
        public double UserPayAmt
        {
            get; set;
        }

        //to store data
        public Receipt()
        {

        }

        public Receipt(DateTime a, string b, double c)
        {
            UserName = b;
            UserPayAmt = c;
        }
    }
}

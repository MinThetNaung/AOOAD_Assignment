using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Customer
    {
        //attributes
        private string userid;
        private string username;
        private string useraddress;

        //creating property for each attribute
        public string UserID
        {
            get; set;
        }

        public string UserName
        {
            get; set;
        }
        public string UserAddress
        {
            get; set;
        }

        //to create a customer list
        public Customer(string userid, string username, string useraddress )
        {
            UserID = userid;
            UserName = username;
            UserAddress = useraddress;
        }
        
        //to view policy
        public void viewPolicy(string userid)
        {

        }
    }
}

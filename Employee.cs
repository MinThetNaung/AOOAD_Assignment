﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Employee
    {
        //attributes
        private string employeename;
        private string employeeid;
        private string rank;
        private string typeofpolicysold;

        //creating property of each attribute
        public string EmployeeName
        {
            get; set;
        }
        public string EmployeeID
        {
            get; set;
        }
        public string Rank
        {
            get; set;
        }
        public string TypeOfPolicySold
        {
            get; set;
        }

        //to create an employee list
        public Employee()
        {

        }

        //to calculate pay
        public void CalculatePay()
        {

        }

        
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Agent is a sub-class of Employee
    class Agent : Employee
    {
        public Agent(string name, string employeeid, string rank, string typeofpolicysold)
        {
            EmployeeName = name;
            EmployeeID = employeeid;
            Rank = rank;
            TypeOfPolicySold = typeofpolicysold;
        }
    }
}

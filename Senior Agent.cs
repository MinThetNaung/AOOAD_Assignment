using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Senior Agent is a sub-class of Employee
    class Senior_Agent : Employee
    {
        public Senior_Agent(string name, string employeeid, string rank, string typeofpolicysold)
        {
            EmployeeName = name;
            EmployeeID = employeeid;
            Rank = rank;
            TypeOfPolicySold = typeofpolicysold;
        }
    }
}

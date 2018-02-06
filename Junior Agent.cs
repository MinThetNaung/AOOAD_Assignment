using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Junior Agent is a sub-class of Employee
    class Junior_Agent : Employee
    {
        public Junior_Agent(string name, string employeeid, int rank, string typeofpolicysold)
        {
            EmployeeName = name;
            EmployeeID = employeeid;
            Rank = rank;
            TypeOfPolicySold = typeofpolicysold;
        }
    }
}

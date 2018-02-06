using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Rider
    {
        //attribute
        private int accountno;
        private string ridername;
        private string description;
        private int riderprice;

        //creating property for each attribute
        public int AccountNo
        {
            get; set;
        }
        public string RiderName
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public int RiderPrice
        {
            get; set;
        }
        
    }
}

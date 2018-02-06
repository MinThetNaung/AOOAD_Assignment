using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Main_Program
    {
        public static List<Employee> EmployeeList = new List<Employee>();
        public static List<Junior_Agent> JuniorAgentList = new List<Junior_Agent>();
        public static List<Agent> AgentList = new List<Agent>();
        public static List<Senior_Agent> SeniorAgentList = new List<Senior_Agent>();
        public static List<Administrator> AdministratorList = new List<Administrator>();
        public static List<Travel_Insurance> TravelInsuranceList = new List<Travel_Insurance>();
        public static List<Medical_Insurance> MedicalInsuranceList = new List<Medical_Insurance>();
        public static List<Car_Insurance> CarInsuranceList = new List<Car_Insurance>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<InsurancePolicy> InsurancePoliciesList = new List<InsurancePolicy>();

        //implementation of the program
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, Welcome from our Life Provident System!");
            Console.ReadLine();
        }
    }
}

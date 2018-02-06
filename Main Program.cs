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

            //jiayu part
            bool quit = false;
            while (!quit)
            {
                Menu();
                int choice = 0;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                switch (choice)
                {
                    case 1://1. show outstanding insurance premiums
                        Console.WriteLine("\nOption 1. List outstanding insurance premiums\n");
                        displayInsurancePoliciesList(InsurancePoliciesList);
                        break;
                    case 2: // pay outstanding insurance premiums
                        Console.WriteLine("\nOption 2. Pay your outstanding insurance premiums\n");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please enter an option from 0-2");
                        break;
                }
            }
            Console.ReadKey();
        }
        //jiayu part
        static void Menu()
        {
            Console.Write(@"
          Life Provident System
==========================================
1. List outstanding insurance premiums
2. Pay outstanding insurance premiums
0. Exit
==========================================
Enter your option: ");
        }
        //jiayu part not done need the list parts from you the parameters (cinemaList, movieList, screeningList);
        static void displayInsurancePoliciesList(List<InsurancePolicy> InsurancePoliciesList)
        {
            int count = 1;
            Console.WriteLine("{0, -4}{1, -30}{2, -10}{3, -20}{4, -15}{5, -20}", "No ", "Title", "Duration", "Genre", "Classification", "Opening Date");
            foreach (Movie m in movieList)
            {
                List<string> genreList = m.GetGenreList();
                string genre = "";
                foreach (string s in genreList)
                {
                    genre = genre + s + " ";
                }
                Console.WriteLine("{0, -4}{1, -30}{2, -10}{3, -20}{4, -15}{5, -20}", count, m.Title, m.Duration, genre, m.Classification, m.OpeningDate);
                count++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class Main_Program
    {
        //creating employee list
        public static List<Employee> EmployeeList = new List<Employee>();
        public static List<Junior_Agent> JuniorAgentList = new List<Junior_Agent>();
        public static List<Agent> AgentList = new List<Agent>();
        public static List<Senior_Agent> SeniorAgentList = new List<Senior_Agent>();
        public static List<Administrator> AdministratorList = new List<Administrator>();

        //creating policy list
        public static List<InsurancePolicy> InsurancePolicyList = new List<InsurancePolicy>();
        public static List<Travel_Insurance> TravelInsuranceList = new List<Travel_Insurance>();
        public static List<Medical_Insurance> MedicalInsuranceList = new List<Medical_Insurance>();
        public static List<Car_Insurance> CarInsuranceList = new List<Car_Insurance>();

        //creating customer list
        public static List<Customer> CustomerList = new List<Customer>();

        //implementation of the program
        static void Main(string[] args)
        {
            
            Console.WriteLine("          Welcome from our Life Provident System! \n" +
                              "..........................................................\n"+
                              ".  Please choose one of the following options:           .\n"+
                              ".                                                        .\n"+
                              ".                                                        .\n"+
                              ".  1. I am an Employee.                                  .\n"+
                              ".                                                        .\n"+
                              ".  2. I am a Customer.                                   .\n"+
                              ".                                                        .\n"+
                              "..........................................................\n"+
                              "Option : ");
            //retrieving input data
            string answer = Console.ReadLine();

            //local attribute
            string x; //for ID
            string y; //for User

            //Using Switch case to do variable for a list of values where each value is a case
            switch(answer)
            {
                case "1":
                    //statement
                    break;

                case "2":
                    //Jia Yu
                    Console.WriteLine("Enter your ID: ");
                    x = Console.ReadLine();

                    //checking inside the database
                    y = checkCustomer(x);
                    if (y=="Varified")
                    {
                        bool quit = false;
                        while (!quit)
                        {
                            Console.WriteLine("==========================================\n" +
                                              "1.List outstanding insurance premiums     \n" +
                                              "2.Pay outstanding insurance premiums      \n" +
                                              "0.Exit                                    \n" +
                                              "==========================================\n" +
                                              "Enter your option:");
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
                                    //displayInsurancePolicyList(InsurancePolicyList);
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
                    break;
                default:
                    Console.WriteLine("Please try again. You are suggested to choose either 1 or 2. Thank you!");
                    break;
            }
            Console.ReadLine();
 
           
        }
        
       
      //jiayu part not done need the list parts from you the parameters (cinemaList, movieList, screeningList);
        public void displayInsurancePolicyList(List<InsurancePolicy> InsurancePolicyList)
        {
            int count = 1;
            Console.WriteLine("{0, -4}{1, -30}{2, -10}{3, -20}{4, -15}{5, -20}", "No ", "Title", "Duration", "Genre", "Classification", "Opening Date");
            /*foreach (Movie m in movieList)
            {
                List<string> genreList = m.GetGenreList();
                string genre = "";
                foreach (string s in genreList)
                {
                    genre = genre + s + " ";
                }
                Console.WriteLine("{0, -4}{1, -30}{2, -10}{3, -20}{4, -15}{5, -20}", count, m.Title, m.Duration, genre, m.Classification, m.OpeningDate);
                count++;
            }*/
        }



        //checking employee data to varify the user identity
        public static string checkEmployee(string x)
        {
            bool check = false;
            string statusUpdate=string.Empty;

            foreach (Employee Employee in EmployeeList)
            {
                //validate the data (Convert string to upper case)
                if(Employee.EmployeeID.ToUpper()== x.ToUpper())
                {
                    Console.WriteLine("Hello, " + Employee.EmployeeName + "\n");
                    check = true;
                    statusUpdate = "Varified";
                    break;
                }
            }
            if (check==false)
            {
                Console.WriteLine("Invalid credentials!");
                statusUpdate = "Invalid";
            }
            return statusUpdate; // need to have, don't know the reason
        }

        //checking customer data to varify the user identity
        public static string checkCustomer(string x)
        {
            bool check = false;
            string statusUpdate = string.Empty;

            foreach (Customer Customer in CustomerList)
            {
                //validate the data (Convert string to upper case)
                if (Customer.UserID.ToUpper() == x.ToUpper())
                {
                    Console.WriteLine("Hello, " + Customer.UserName + "\n");
                    check = true;
                    statusUpdate = "Varified";
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Invalid credentials!");
                statusUpdate = "Invalid";
            }
            return statusUpdate; // need to have, don't know the reason

        }


    }
}

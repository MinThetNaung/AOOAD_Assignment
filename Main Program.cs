using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

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

        //creating receipt list
        public static List<Receipt> ReceiptList = new List<Receipt>();

        //implementation of the program
        static void Main(string[] args)
        {
            database();   
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
                            Console.WriteLine("==========================================\n" +
                                              "1.List outstanding insurance premiums     \n" +
                                              "2.Pay outstanding insurance premiums      \n" +
                                              "0.Exit                                    \n" +
                                              "==========================================\n" +
                                              "Enter your option:");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.WriteLine("{0, -30}{1, -30}{2, -20}", "startDate", "endDate", "premiumPrice");
                            //look for required data in customer list
                            foreach (Customer customer in CustomerList)
                            {
                                if (customer.UserID == x)
                                {
                                    foreach (InsurancePolicy i in InsurancePolicyList)
                                    {
                                        //implement statement

                                        Console.WriteLine("{0, -30}{1, -30}{2, -20}", i.startDate, i.endDate, i.premiumPrice);
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                }

                            }

                        }
                        else if (choice == "2") {
                            Console.WriteLine("Enter Full Name on Credit Card: ");
                            string userName = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Credit Card Number: ");
                            string userCreditNo = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Expiry Date: ");
                            string userCreditExpiry = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Security Code: ");
                            string userCreditCode = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Pin: ");
                            string userCreditPin = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Enter Payment Amount: ");
                            double userPayAmt = Convert.ToDouble(Console.ReadLine());

                            //Append to Receipt List
                            Receipt r1 = new Receipt(DateTime.Now, userName, userPayAmt);
                            ReceiptList.Add(r1);

                            //Display Receipt
                            Console.WriteLine("{0,-25} {1,-20} {2,-15}", "Date & Time", "Client Name", "Payment Amount");
                            Console.WriteLine("{0,-25} {1,-20} {2,-15}", DateTime.Now, userName, userPayAmt);
                            Console.WriteLine("Paid");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!");
                        }
                                  
                    }
                    break;
                default:
                    Console.WriteLine("Please try again. You are suggested to choose either 1 or 2. Thank you!");
                    break;
            }
            Console.ReadLine();
 
           
        }
        
       
      //jiayu 
        /*public static void displayInsurancePolicyList(List<InsurancePolicy> InsurancePolicyList)
        {
             int count = 1;
            Console.WriteLine("{0, -10}{1, -30}{2, -10}{3, -20}{4, -15}{5, -20}", "status ", "policyid", "termsNcondition", "payout", "paymentTypes", "startDate", "endDate", "premiumType", "premiumPrice");
            
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
        }*/



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

        public static void database()
        {
            //Customer List
            Customer customer1 = new Customer("0001", "Bunny", "Mandalay");
            CustomerList.Add(customer1);

            Customer customer2 = new Customer("0002", "Yamin", "Pathein");
            CustomerList.Add(customer2);

            Customer customer3 = new Customer("0003", "Sonia", "Singapore");
            CustomerList.Add(customer3);


            //InsurancePolicy List

            //Travel
            Travel_Insurance travel1 = new Travel_Insurance("Active", 0001, "Follow the rules.", "100", "Credit Card", Convert.ToDateTime("29-12-2016"), Convert.ToDateTime("29-12-2018"), "Monthly",200);
            TravelInsuranceList.Add(travel1);
            InsurancePolicyList.Add(travel1);

            //Car
            Car_Insurance car1 = new Car_Insurance("Lapsed", 0002, "Follow the rules.", "100", "Cheque", Convert.ToDateTime("05-04-2016"), Convert.ToDateTime("24-10-2019"), "Yearly", 100);
            CarInsuranceList.Add(car1);
            InsurancePolicyList.Add(car1);

            //Medical
            Medical_Insurance medical1 = new Medical_Insurance("Out of Service!", 0003, "Follow the rules.", "100", "Credit Card", Convert.ToDateTime("29-10-2016"), Convert.ToDateTime("29-01-2019"), "One-Time", 1000);
            MedicalInsuranceList.Add(medical1);
            InsurancePolicyList.Add(medical1);


            //Employee List

            //Junior Agent
            Junior_Agent junior1 = new Junior_Agent("Leo", "0001", 2, "Travel & Car");
            JuniorAgentList.Add(junior1);
            EmployeeList.Add(junior1);

            //Agent
            Agent agent1 = new Agent("Ye Yint", "0002", 5, "Travel & Medical");
            AgentList.Add(agent1);
            EmployeeList.Add(agent1);

            //Senior Agent
            Senior_Agent senior1 = new Senior_Agent("Jia Yu", "0003", 6, "Medical & Car");
            SeniorAgentList.Add(senior1);
            EmployeeList.Add(senior1);


            //Administrator
            Administrator admin1 = new Administrator("Sherlock", "0004", 1, "Car");
            AdministratorList.Add(admin1);
            EmployeeList.Add(admin1);



        }

    }
}

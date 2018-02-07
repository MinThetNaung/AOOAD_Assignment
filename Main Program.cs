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

        //creating administrator list
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
            start:
            database();
            Console.WriteLine("          Welcome from our Life Provident System! \n" +
                              "..........................................................\n" +
                              ".       Please choose one of the following options:      .\n" +
                              ".                                                        .\n" +
                              ".                                                        .\n" +
                              ".              1. I am an Employee.                      .\n" +
                              ".                                                        .\n" +
                              ".              2. I am a Customer.                       .\n" +
                              ".                                                        .\n" +
                              ".              3. I am an Administrator.                       .\n" +
                              ".                                                        .\n" +
                              "..........................................................\n" +
                              "Option : ");
            //retrieving input data
            string answer = Console.ReadLine();

            //local attribute
            string x; //for ID
            string y; //for User

            //Using Switch case to do variable for a list of values where each value is a case
            switch (answer)
            {
                //Case 1 start
                case "1":
                    Console.WriteLine("Enter your ID: ");
                    x = Console.ReadLine();

                    //checking inside the database
                    y = checkEmployee(x);
                    if (y == "Varified")
                    {
                        begin:
                        Console.WriteLine("=============== Main Menu=================\n" +
                                          "1.Create Insurance Policy                 \n" +
                                          "2.Edit Insurance Policy                   \n" +
                                          "3.Delete Insurance Policy                 \n" +
                                          "4.Send Auto-Generated Email               \n" +
                                          "5.Log Out                                 \n" +
                                          "0.Exit                                    \n" +
                                          "==========================================\n" +
                                          "Option : ");
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                //checking employee id in database
                                Console.WriteLine("Employee ID : ");
                                string employeeid = Console.ReadLine();

                                if (x == employeeid)
                                {
                                    createPolicy();

                                    goto begin;

                                }
                                else
                                {
                                    Console.WriteLine("Invalid Credentials!");

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    goto begin;
                                }



                            case "2":
                                editPolicy();
                                goto begin;
                                break;



                            case "3":
                                deletePolicy();
                                goto begin;
                                break;



                            case "4":
                                sendEmail();
                                goto begin;
                                break;



                            case "5":
                                goto start;
                                break;



                            case "0":
                                Environment.Exit(0);
                                break;



                        }


                    }
                    break;
                //Case 1 ends


                //Case 2 starts
                case "2":
                    //Jia Yu
                    Console.WriteLine("Enter your ID: ");
                    x = Console.ReadLine();

                    //checking inside the database
                    y = checkCustomer(x);
                    if (y == "Varified")
                    {
                        stage:
                        Console.WriteLine("==========================================\n" +
                                          "1.List outstanding insurance premiums     \n" +
                                          "2.Pay outstanding insurance premiums      \n" +
                                          "0.Exit                                    \n" +
                                          "==========================================\n" +
                                          "Enter your option:");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.WriteLine("{0, -30}{1, -30}{2, -20}", "StartDate", "EndDate", "PremiumPrice");
                            //look for required data in customer list
                            foreach (Customer customer in CustomerList)
                            {
                                if (customer.UserID == x)
                                {
                                    foreach (InsurancePolicy i in InsurancePolicyList)
                                    {

                                        Console.WriteLine("{0, -30}{1, -30}{2, -20}", i.StartDate, i.EndDate, i.PremiumPrice);
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                }

                            }
                            goto stage;
                        }
                        else if (choice == "2")
                        {
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


                            goto stage;
                        }
                        else if (choice == "0")
                        {
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!");
                            goto start;
                        }

                    }
                    break;

                case "3":
                    //Ye Yint
                    Console.WriteLine("Enter your EmployeeID: ");
                    x = Console.ReadLine();

                    //checking inside the database
                    y = checkAdministrator(x);
                    if (y == "Varified")
                    {
                        stage:
                        Console.WriteLine("==========================================\n" +
                                          "Are you viewing Policies?                 \n" +
                                          "1.Yes                                     \n" +
                                          "0.No                                      \n" +
                                          "==========================================\n" +
                                          "Enter your option: ");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            Console.WriteLine("============================================\n" +
                                              "Which type of policy do you want to view?   \n" +
                                              "1. Travel Insurance                         \n" +
                                              "2. Car Insurance                            \n" +
                                              "3. Medical Insurance                        \n" +
                                              "============================================\n" +
                                              "Enter your Option: ");
                            string typeChoice = Console.ReadLine();
                          /*  if (typeChoice != "1" || typeChoice != "2" || typeChoice != "3")
                                Console.WriteLine("Invalid Credentials!");
                            break;
*/
                            Console.WriteLine("============================================\n" +
                                              "Choose your Status                          \n" +
                                              "1. Active                                   \n" +
                                              "2. Lapsed                                   \n" +
                                              "============================================\n" +
                                              "Enter your option: ");
                            string conditionChoice = Console.ReadLine();
                            /*if (conditionChoice != "1" || conditionChoice != "2")
                                Console.WriteLine("Invalid Credentials!");
                            break;
                            */
                            if (typeChoice == "1" && conditionChoice == "1")
                            {
                                foreach (Travel_Insurance t in TravelInsuranceList)
                                {
                                    if (t.Status == "Active")
                                    {
                                        foreach (Travel_Insurance i in TravelInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            else if (typeChoice == "1" && conditionChoice == "2")
                            {
                                foreach (Travel_Insurance t in TravelInsuranceList)
                                {
                                    if (t.Status == "Lapsed")
                                    {
                                        foreach (Travel_Insurance i in TravelInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            else if (typeChoice == "2" && conditionChoice == "1")
                            {
                                foreach (Car_Insurance c in CarInsuranceList)
                                {
                                    if (c.Status == "Active")
                                    {
                                        foreach (Car_Insurance i in CarInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            else if (typeChoice == "2" && conditionChoice == "2")
                            {
                                foreach (Car_Insurance c in CarInsuranceList)
                                {
                                    if (c.Status == "Lapsed")
                                    {
                                        foreach (Car_Insurance i in CarInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            else if (typeChoice == "3" && conditionChoice == "1")
                            {
                                foreach (Medical_Insurance m in MedicalInsuranceList)
                                {
                                    if (m.Status == "Active")
                                    {
                                        foreach (Medical_Insurance i in MedicalInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            else if (typeChoice == "3" && conditionChoice == "2")
                            {
                                foreach (Medical_Insurance m in MedicalInsuranceList)
                                {
                                    if (m.Status == "Lapsed")
                                    {
                                        foreach (Medical_Insurance i in MedicalInsuranceList)
                                        {
                                            Console.WriteLine(i.Status, i.TypesOfPolicy, i.PolicyIdentification, i.TermsAndCondition, i.PayOut, i.PaymentType, i.StartDate, i.EndDate, i.PremiumType, i.PremiumPrice);
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            break;
                        }
                        else if (choice == "0")
                        {
                            Console.WriteLine("Thank you for using our Life Provident System!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!");
                            break;
                        }

                    }
                    break;

                default:
                    //Console.WriteLine("Please try again. You are suggested to choose either 1 or 2. Thank you!");

                    break;
                    goto start;
            }
            Console.Read();


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
            string statusUpdate = string.Empty;

            foreach (Employee Employee in EmployeeList)
            {
                //validate the data (Convert string to upper case)
                if (Employee.EmployeeID.ToUpper() == x.ToUpper())
                {
                    Console.WriteLine("Hello, " + Employee.EmployeeName + "\n");
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

        //checking administrator data to varify the user identity
        public static string checkAdministrator(string x)
        {
            bool check = false;
            string statusUpdate = string.Empty;

            foreach (Administrator Administrator in AdministratorList)
            {
                //validate the data (Convert string to upper case)
                if (Administrator.EmployeeID.ToUpper() == x.ToUpper())
                {
                    Console.WriteLine("Hello, " + Administrator.EmployeeName + "\n");
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

            string dateTime1 = "25-01-2016";
            string dateTime2 = "25-01-2018";
            Travel_Insurance travel1 = new Travel_Insurance("Active", "Travel", 0001, "Follow the rules.", "100", "Credit Card", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "Monthly", 200);
            TravelInsuranceList.Add(travel1);
            InsurancePolicyList.Add(travel1);

            Travel_Insurance travel2 = new Travel_Insurance("Lapsed", "Travel", 0004, "Follow the rules.", "100", "Cheque", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "Monthly", 200);
            TravelInsuranceList.Add(travel2);
            InsurancePolicyList.Add(travel2);

            //Car
            Car_Insurance car1 = new Car_Insurance("Active", "Car", 0002, "Follow the rules.", "100", "Cheque", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "Yearly", 100);
            CarInsuranceList.Add(car1);
            InsurancePolicyList.Add(car1);

            Car_Insurance car2 = new Car_Insurance("Lapsed", "Car", 0005, "Follow the rules.", "100", "Credit Card", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "Yearly", 100);
            CarInsuranceList.Add(car2);
            InsurancePolicyList.Add(car2);

            //Medical
            Medical_Insurance medical1 = new Medical_Insurance("Active", "Medical", 0003, "Follow the rules.", "100", "Credit Card", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "One-Time", 1000);
            MedicalInsuranceList.Add(medical1);
            InsurancePolicyList.Add(medical1);

            Medical_Insurance medical2 = new Medical_Insurance("Lapsed", "Medical", 0006, "Follow the rules.", "100", "Cheque", Convert.ToDateTime(dateTime1), Convert.ToDateTime(dateTime2), "One-Time", 1000);
            MedicalInsuranceList.Add(medical2);
            InsurancePolicyList.Add(medical2);


            //Employee List

            //Junior Agent
            Junior_Agent junior1 = new Junior_Agent("Leo", "0001", "Junior Agent", "Travel & Car");
            JuniorAgentList.Add(junior1);
            EmployeeList.Add(junior1);

            //Agent
            Agent agent1 = new Agent("Ye Yint", "0002", "Agent", "Travel & Medical");
            AgentList.Add(agent1);
            EmployeeList.Add(agent1);

            //Senior Agent
            Senior_Agent senior1 = new Senior_Agent("Jia Yu", "0003", "Senior Agent", "Medical & Car");
            SeniorAgentList.Add(senior1);
            EmployeeList.Add(senior1);


            //Administrator List

            //Administrator
            Administrator admin = new Administrator("Kalorie", "0001", "Admin", "Car");
            AdministratorList.Add(admin);
        }

        //To create policy
        public static void createPolicy()
        {

            //checking customer id in database
            Console.WriteLine("Customer ID [000x] : ");
            string userid = Convert.ToString(Console.ReadLine());
            Customer ct = null;
            for (int i = 0; i < CustomerList.Count; i++)
            {
                if (userid == CustomerList[i].UserID)
                {
                    ct = CustomerList[i];
                    break;
                }


                else
                {
                    Console.WriteLine("Invalid Credentials!");
                    createPolicy();
                    break;
                }
               // break;
            }



            //Start asking
            Console.WriteLine("Status[Active | Lapsed | Out of Service!] : ");
            string status = Console.ReadLine();

            Console.WriteLine("Types Of Policy [Car | Medical | Travel] : ");
            string typesOfPolicy = Console.ReadLine();


            Console.WriteLine("PolicyID [xxx1] : ");
            int policyID = Convert.ToInt32(Console.ReadLine()); //int and string converting

            Console.WriteLine("Terms & Conditions [Follow the rules.] : ");
            string termNcondition = Console.ReadLine();

            Console.WriteLine("Payout [2xxx] : ");
            string payout = Console.ReadLine();

            Console.WriteLine("PaymentTypes [Credit Card | Cheque] : ");
            string paymentType = Console.ReadLine();

            Console.WriteLine("Start Date [DD-MM-YYYY] : ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("End Date [DD-MM-YYYY] : ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Premium Type [Monthly | Yearly | One-Time ] :");
            string premiumType = Console.ReadLine();

            Console.WriteLine("Premium Price [2xxx] : ");
            double premiumPrice = Convert.ToDouble(Console.ReadLine());

            InsurancePolicy newPolicy = new InsurancePolicy(status, typesOfPolicy, policyID, termNcondition, payout, paymentType, startDate, endDate, premiumType, premiumPrice);
            InsurancePolicyList.Add(newPolicy);
            newPolicy.Customer = ct;


            Console.WriteLine("A new Policy has been created!");
            Console.Read();


            /*  if (typesOfPolicy == "Car")
              {
                  Car_Insurance newPolicy = new Car_Insurance(status, typesOfPolicy, policyID, termNcondition, payout, paymentType, startDate, endDate, premiumType, premiumPrice);
                  CarInsuranceList.Add(newPolicy);
                  InsurancePolicyList.Add(newPolicy);

              }

              else if (typesOfPolicy == "Medical")
              {
                  Medical_Insurance newPolicy = new Medical_Insurance(status, typesOfPolicy, policyID, termNcondition, payout, paymentType, startDate, endDate, premiumType, premiumPrice);
                  MedicalInsuranceList.Add(newPolicy);
                  InsurancePolicyList.Add(newPolicy);
              }

              else if (typesOfPolicy == "Travel")
              {
                  Travel_Insurance newPolicy = new Travel_Insurance(status, typesOfPolicy, policyID, termNcondition, payout, paymentType, startDate, endDate, premiumType, premiumPrice);
                  TravelInsuranceList.Add(newPolicy);
                  InsurancePolicyList.Add(newPolicy);
              }

      */

        }


        //To edit Policy
        public static void editPolicy()
        {
            Console.WriteLine("Invalid Function At this moment!");
            Console.Read();


        }

        //To delete policy
        //Policy can be terminated in three ways
        //If the client decides to cancel the policy, whereupon he must pay a cancellation penalty
        //If the policy is paid out (either because the terms of coverage occurred or the maturity date is reached)
        //The policy is canceled by the agent because the client cannot be contacted
        public static void deletePolicy()
        {
            Console.WriteLine("Invalid Function At this moment!");
            Console.Read();
        }

        public static void sendEmail()
        {
            Console.WriteLine("Invalid Function At this moment!");
            Console.Read();
        }


    }
}

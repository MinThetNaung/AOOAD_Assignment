using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    class InsurancePolicy
    {
        public string status;
        public int policyid;
        public string termsNcondition;
        public string payout;  // different policy have different payout
        public string paymentTypes; //credit card or cheque
        public DateTime startDate;
        public DateTime endDate;
        public string premiumType; // One-time payment, periodic payment (monthly or yearly)
        public double premiumPrice;

       // public List<InsurancePolicy> PolicyList;

        //Extension method with other classes
        private Employee employee;
        private Customer customer;
        private Rider rider;
        

        //Creating property of each attribute
        public string Status
        {
            get; set;
        }
        public int PolicyIdentification
        {
            get; set;
        }
        public string TermsAndCondition
        {
            get; set;
        }
        public string PayOut
        {
            get; set;
        }
        public string PaymentType
        {
            get; set;
        }
        public DateTime StartDate
        {
            get; set;
        }
        public DateTime EndDate
        {
            get; set;
        }
        public string PremiumType
        {
            get; set;
        }
        public double PremiumPrice
        {
            get; set;
        }

        public Employee Employee
        {
            get; set;
        }
        public Customer Customer
        {
            get; set;
        }
        public Rider Rider
        {
            get; set;
        }


        //To delete policy
        //Policy can be terminated in three ways
        //If the client decides to cancel the policy, whereupon he must pay a cancellation penalty
        //If the policy is paid out (either because the terms of coverage occurred or the maturity date is reached)
        //The policy is canceled by the agent because the client cannot be contacted
        public void DeletePolicy()
         {

         }

        // to edit the policy
        /*public InsurancePolicy(string status, int policyid, string termsNcondition, string payout, string paymentTypes, DateTime startDate, DateTime endDate, string premiumType, double premiumPrice)
        {
            Status = status;
            PolicyIdentification = policyid;
            TermsAndCondition = termsNcondition;
            PayOut = payout;
            PaymentType = paymentTypes;
            StartDate = startDate;
            EndDate = endDate;
            PremiumType = premiumType;
            PremiumPrice = premiumPrice;

        }*/
    }
}

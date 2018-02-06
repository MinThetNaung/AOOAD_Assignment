using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Car Insurance is a sub-class of Insurance Policy
    class Car_Insurance : InsurancePolicy
    {
        public Car_Insurance(string status, int policyid, string termsNcondition, string payout, string paymentTypes, DateTime startDate, DateTime endDate, string premiumType, double premiumPrice)
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

        }
    }
}

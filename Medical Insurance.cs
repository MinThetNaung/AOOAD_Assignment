using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    // Medical Insurance is a sub class of Insurance Policy
    class Medical_Insurance : InsurancePolicy
    {
        public Medical_Insurance(string status,string typesOfPolicy, int policyid, string termsNcondition, string payout, string paymentTypes, DateTime startDate, DateTime endDate, string premiumType, double premiumPrice)
        {
            Status = status;
            TypesOfPolicy = typesOfPolicy;
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

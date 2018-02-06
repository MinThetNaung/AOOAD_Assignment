using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOAD_Assignment
{
    //Travel Insurance is a sub class of Insurance Policy
    class Travel_Insurance : InsurancePolicy
    {
        public Travel_Insurance(string status, int policyid, string termsNcondition, string payout, string paymentTypes, DateTime startDate, DateTime endDate, string premiumType, double premiumPrice)
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

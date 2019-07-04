using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    // Stub class to act as a PayPal web service
    public class MockPayPalWebService
    {
        public string ObtainToken(string AccountName, string Password)
        {
            return "xxxxxxxxxxxx-xxxxxxxxxxx";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth:0999";
        }
    }
}

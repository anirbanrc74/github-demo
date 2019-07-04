using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    public class MockWorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionId, string username, string password, string ProductId)
        {
            return "A_Success-09901";
        }
    }
}

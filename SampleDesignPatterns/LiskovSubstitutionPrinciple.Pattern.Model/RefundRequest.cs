using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    public class RefundRequest
    {
        public PaymentType Payment { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal RefundAmount { get; set; }
    }
}

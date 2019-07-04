using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    /* PaymentServiceBase class is introduced to enable RefundService to interact with the payment merchants
     * as if they had the same interface. So, WorldPayPayment and PayPalPayment can inherit from PaymentServiceBase
     * class to wrap the real web service APIs by using adapter pattern.
     * The RefundService can interact with the abstract PaymentServiceBase class and be blissfully unaware of which
     * real implementation it is dealing with because they both behave the same - the essence of the LSP.
     */
    public abstract class PaymentServiceBase
    {
        public abstract RefundResponse Refund(decimal amount, string transactionId);
    }
}

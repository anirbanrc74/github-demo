using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    public class RefundService
    {
        public RefundResponse Refund(RefundRequest refundRequest)
        {
            PaymentServiceBase paymentService = PaymentServiceFactory.GetPaymentServiceFrom(refundRequest.Payment);
            RefundResponse refundResponse;

            refundResponse = paymentService.Refund(refundRequest.RefundAmount, refundRequest.PaymentTransactionId);

            return refundResponse;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Pattern.Model
{
    //Paypal payment merchant adapter
    public class PayPalPayment : PaymentServiceBase
    {
        public PayPalPayment(string AccountName, string Password)
        {
            this.AccountName = AccountName;
            this.Password = Password;
        }

        public string AccountName { get; set; }
        public string Password { get; set; }

        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            MockPayPalWebService payPalWebService = new MockPayPalWebService();
            RefundResponse refundResponse = new RefundResponse();

            string token = payPalWebService.ObtainToken(AccountName, Password);

            string response = payPalWebService.MakeRefund(amount, transactionId, token);

            refundResponse.Message = response;

            if (response.Contains("Auth"))
                refundResponse.Success = true;
            else
                refundResponse.Success = false;

            return refundResponse;
        }
    }
}

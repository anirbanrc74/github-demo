using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    /* ReturnOrder entity represents the customer's order being returned. The Action property determines what
     * type of return order it is, PaymentTransactionId refers to the original payment used to purchase the
     * order, PricePaid & PostageCost refers to the order total & shipping costs respectively. ProductId holds
     * the unique identifier of the product being returned. Finally, the AmountToRefund is set, that is the
     * amount to be refunded to the customer.
     */
    public class ReturnOrder
    {
        public ReturnAction Action { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal PricePaid { get; set; }
        public decimal PostageCost { get; set; }
        public decimal AmountToRefund { get; set; }
        public long ProductId { get; set; }
        public long QtyBeingReturned { get; set; }
    }
}

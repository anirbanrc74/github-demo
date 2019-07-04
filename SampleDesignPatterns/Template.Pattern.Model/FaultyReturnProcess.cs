using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    /* FaultyReturnProcess handles processing of faulty returned items. The overridden 
     * GenerateReturnTransactionFor method creates a manufacturer return order for sending faulty item for a
     * refund. In this case refund money includes postage charges.
     */
    public class FaultyReturnProcess : ReturnProcessTemplate
    {
        protected override void GenerateReturnTransactionFor(ReturnOrder ReturnOrder)
        {
            // Code to send generate order that sends faulty item back to
            // manufacturer...
        }

        protected override void CalculateRefundFor(ReturnOrder ReturnOrder)
        {
            ReturnOrder.AmountToRefund = ReturnOrder.PricePaid + ReturnOrder.PostageCost;
        }
    }
}

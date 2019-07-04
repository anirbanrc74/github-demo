using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    /* NoQuibblesReturnProcess returns the item into stock and considers only paid price which doesn't include
     * postage charges
     */
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void GenerateReturnTransactionFor(ReturnOrder ReturnOrder)
        {
            // Code to put items back into stock...
        }

        protected override void CalculateRefundFor(ReturnOrder ReturnOrder)
        {
            ReturnOrder.AmountToRefund = ReturnOrder.PricePaid;
        }
    }
}

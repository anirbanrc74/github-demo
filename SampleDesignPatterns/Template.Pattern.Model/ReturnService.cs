using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    /* Service class - coordinates the process of returning an item. This service class first obtains a 
     * ReturnProcessTemplate implementaion from the factory, passing in the ReturnOrder entity, and in turn
     * calls the process method on the ReturnProcessTemplate. The call returns the item using the subclass's
     * method and calculates the amount that the customer is entitled to receive.
     */
    public class ReturnService
    {
        public void Process(ReturnOrder ReturnOrder)
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(ReturnOrder.Action);

            returnProcess.Process(ReturnOrder);

            // Code to refund the back to the customer...
        }
    }
}

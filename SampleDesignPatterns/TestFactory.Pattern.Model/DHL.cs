using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory.Pattern.Model
{
    public class DHL : IShippingCourier
    {
        public string GetConsignmentLabelFor(Address address)
        {
            return "DHL-XXXXXXXXX-XXXXXXXXX";
        }
    }
}

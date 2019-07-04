using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory.Pattern.Model
{
    public interface IShippingCourier
    {
       string GetConsignmentLabelFor(Address address);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pattern.Model
{
    public interface IShippingCourier
    {
        string GenerateConsignmentLabelFor(Address address);
    }
}

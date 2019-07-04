using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Model
{
    public interface IDiscountStrategy  //Strategy pattern - algorithms encapsulated in classes can be selected & changed at runtime
    {
        decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice);
    }
}

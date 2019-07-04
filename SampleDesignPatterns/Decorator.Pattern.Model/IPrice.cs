using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /*Decorator objects implements the IPrice interface
     * Interface for Product.
     */
    public interface IPrice
    {
        decimal Cost { get; set; }
    }
}

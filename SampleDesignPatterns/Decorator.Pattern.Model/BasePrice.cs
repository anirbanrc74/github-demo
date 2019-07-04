using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /*Codes to IPrice interface. This class gives dafault behavior of the producs price and usually set by the
     * repository when hydrating a list of products from the data store.
     * This class provides base functionality that can be decorated.
     */
    public class BasePrice : IPrice
    {
        private Decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}

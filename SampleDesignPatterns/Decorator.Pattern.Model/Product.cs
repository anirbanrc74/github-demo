using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    //Product entity
    public class Product
    {
        public IPrice Price { get; set; }
    }
}

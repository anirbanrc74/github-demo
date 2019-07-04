using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    //Enum to determine which type of return order is being processed.
    public enum ReturnAction
    {
        FaultyReturn = 0,
        NoQuibblesReturn = 1
    }
}

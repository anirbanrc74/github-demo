using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    public static class ReturnProcessFactory
    {
        /* Returns correct processing class based on the type of order being returned. So, this Factory class
         * returns the correct processing object. Factory class hides the complexities from any client and
         * ensures that the logic is contained in one place and is the responsibility of the Factory class.
         */
        public static ReturnProcessTemplate CreateFrom(ReturnAction ReturnAction)
        {
            switch (ReturnAction)
            {
                case (ReturnAction.FaultyReturn):
                    return new FaultyReturnProcess();
                case (ReturnAction.NoQuibblesReturn):
                    return new NoQuibblesReturnProcess();
                default:
                    throw new ApplicationException("No Process Template defined for Return Action of " +
                                                   ReturnAction.ToString());
            }
        }
    }
}

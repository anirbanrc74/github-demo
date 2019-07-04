using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Model
{
    /* Template method pattern belongs to the behavioral group of design patterns and is applied when a
     * skeleton of an algorithm is defined but some steps are deferred to subclasses. The structure and the flow
     * of the algorithm remain static, but the details of the steps are deferred to subclasses.
     * Template method that will be overridden by the specific faulty and no quibbles subclasses. The class &
     * first 2 methods are abstract and are required to be implemented by a subclass.
     * The AbstractClass defines a skeleton process workflow with abstract steps that ConcreteClassA & (,B..etc)
     * override & implement. This enables details of algorithm to alter depending on subclasses but allow
     * structure to remain consistent.
     * ConcreteClassA & (,B..etc) inherit from AbstractClass, implement the abstarct methods, and give the
     * detail to the algorithm.
     * Template method pattern is useful to centralize code common to a series of subclasses. Code that varies
     * is seperated from the code that is similar. This enables to avoid duplication and enables better
     * maintenance of code base.
     */
    public abstract class ReturnProcessTemplate
    {
        protected abstract void GenerateReturnTransactionFor(ReturnOrder ReturnOrder);
        protected abstract void CalculateRefundFor(ReturnOrder ReturnOrder);

        public void Process(ReturnOrder ReturnOrder)
        {
            GenerateReturnTransactionFor(ReturnOrder);
            CalculateRefundFor(ReturnOrder);
        }
    }
}

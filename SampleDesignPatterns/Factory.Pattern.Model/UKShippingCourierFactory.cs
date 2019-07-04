using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pattern.Model
{
    public static class UKShippingCourierFactory
    {
    /*Factory class - decides which courier object to use based on business logic
     * Codes to interface
     * Factory method pattern belongs to the creational group of design patterns and handles the issue of 
     * creating objects without specifying the exact class of object to be created.
     * The main objective of the factory pattern is to hide the complexities of creating objects. Client
     * shouldn't normally specify a particular class to be created. Instead, the client will code against an
     * interface or abstract class and leave responsibility to the factory class to create the concrete type.
     * Typically factory class has a static method that returns an abstract class or interface. Client usually
     * supplies some information; using the supplied information the Factory then determines which subclass to
     * create & return.
     * The ability to abstarct away the responsibility of creating subclasses allows client code to be 
     * completely ignorant of how dependent classes are created. This follows dependency inversion principle.
     * Another benefit of Factory Method Pattern is that the code for the creation of objects is centralized.
     * So, if a change is required in the way object is generated, it can be easily located & updated without 
     * affecting the code that depends on it.
     */
         
        public static IShippingCourier CreateShippingCourier(Order order)
        {
            if ((order.TotalCost > 100) || (order.WeightInKG > 5))
                return new DHL();
            else
                return new RoyalMail();
        }
    }
}

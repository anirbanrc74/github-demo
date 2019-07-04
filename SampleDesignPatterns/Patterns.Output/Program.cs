using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Pattern.Model;
using Strategy.Pattern.Model;

namespace Patterns.Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Order objOrder = new Order { TotalCost=200, WeightInKG=10, DispatchAddress=new Address { CountryCode = "UK" }, CourierTrackingId="Empty" };
            OrderService objOrderService = new OrderService();
            objOrderService.Dispatch(objOrder);
            Console.WriteLine("No error means - Non Empty Courier Tracking ID :- " + objOrder.CourierTrackingId);
            Console.WriteLine();
            Basket objBasket = new Basket(DiscountType.MoneyOff);
            objBasket.TotalCost = 105;
            Console.WriteLine("Price with discount :- " + objBasket.GetTotalCostAfterDiscount());
            Console.ReadLine();
        }
    }
}

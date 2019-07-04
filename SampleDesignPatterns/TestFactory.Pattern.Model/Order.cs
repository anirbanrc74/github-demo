using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory.Pattern.Model
{
    public class Order
    {
        public decimal TotalCost { get; set; }
        public decimal WeightInKg { get; set; }
        public string CourierTrackingId { get; set; }

        public Address DispatchAddress { get; set; }

    }
}

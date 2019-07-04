﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Model
{
    public class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice)
        {
            return OriginalSalePrice;
        }
    }
}
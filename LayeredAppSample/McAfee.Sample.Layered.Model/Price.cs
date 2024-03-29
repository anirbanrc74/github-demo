﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy = new NullDiscountStrategy();
        private decimal _rrp;
        private decimal _sellingPrice;

        public Price(decimal RRP, decimal SellingPrice)
        {
            _rrp = RRP;
            _sellingPrice = SellingPrice;
        }
        //Dependency injection - setter - discount strategy applied can be swaped
        public void SetDiscountStrategyTo(IDiscountStrategy DiscountStrategy)
        {
            _discountStrategy = DiscountStrategy;
        }

        public decimal SellingPrice
        {
            get { return _discountStrategy.ApplyExtraDiscountsTo(_sellingPrice); }
        }

        public decimal RRP
        {
            get { return _rrp; }
        }

        public decimal Discount
        {
            get
            {
                if (RRP > SellingPrice)
                    return (RRP - SellingPrice);
                else
                    return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (RRP > SellingPrice)
                    return 1 - (SellingPrice / RRP);
                else
                    return 0;
            }
        }
    }
}

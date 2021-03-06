﻿using System.Collections.Generic;
using System.Linq;

namespace BBTest2
{
    public class Calculator
    {
        private readonly Basket _basket;
        private readonly List<IDiscounts> _discounts;
        public Calculator(Basket basket, List<IDiscounts> discounts)
        {
            _basket = basket;
            _discounts = new List<IDiscounts> {new ButterBread(), new MilkDiscount()};
        }

        public decimal Calculate()
        {
            return _basket.Products.Sum(x => x.Value) - CalculateDiscount();
        }

        public decimal CalculateDiscount()
        {
            return _discounts.Sum(discount => discount.HasMatched(_basket.Products) ? discount.ReturnDiscount(_basket.Products) : 0);
        }
    }
}
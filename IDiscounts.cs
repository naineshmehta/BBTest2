using System;
using System.Collections.Generic;

namespace BBTest2
{
    public interface IDiscounts
    {
        decimal DiscountValue { get; set; }
        Boolean HasMatched(List<Product> products);
        decimal ReturnDiscount(List<Product> products);
    }
}
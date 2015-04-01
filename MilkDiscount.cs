using System.Collections.Generic;
using System.Linq;

namespace BBTest2
{
    public class MilkDiscount : IDiscounts
    {
        public decimal DiscountValue { get; set; }
        public MilkDiscount()
        {
            DiscountValue = (decimal) 1.15;
        }

        public bool HasMatched(List<Product> products)
        {
            var milkCount = products.Count(x => x.Name == "milk");
            return milkCount > 3;
        }

        public decimal ReturnDiscount(List<Product> products)
        {
            var count = products.Count(x => x.Name == "milk")/4; 
            if (count > 0)
            {
                return count*DiscountValue;
            }
            return 0;
        }
    }
}
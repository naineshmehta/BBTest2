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
            return milkCount == 4;
        }
    }
}
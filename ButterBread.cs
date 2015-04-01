using System.Collections.Generic;
using System.Linq;

namespace BBTest2
{
    public class ButterBread : IDiscounts
    {
        public decimal DiscountValue { get; set; }
        
        public ButterBread()
        {
            DiscountValue = (decimal) 0.5;
        }

        public bool HasMatched(List<Product> products)
        {
            var breadcount = products.Count(x => x.Name == "bread");
            return breadcount == 2;
        }
    }
}
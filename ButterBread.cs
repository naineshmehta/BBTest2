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
            var butterCount = products.Count(x => x.Name == "butter");
            return butterCount == 2;
        }

        public decimal ReturnDiscount(List<Product> products)
        {
            return DiscountValue;
        }
    }
}
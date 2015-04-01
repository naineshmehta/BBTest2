using System.Collections.Generic;

namespace BBTest2
{
    public class Basket
    {
        public List<Product> Products;

        public Basket()
        {
            Products = new List<Product>();
        }

        public void Add(Product item)
        {
            Products.Add(item);
        }
    }
}
namespace BBTest2
{
    public class Product
    {
        public Product(string item, decimal value)
        {
            Name = item;
            Value = value;
        }

        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}
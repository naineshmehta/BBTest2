using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BBTest2
{
    [TestFixture]
    public class CartTests
    {
        private Basket _basket;
        private Calculator _calculator;
        private List<IDiscounts> _discounts;

        [SetUp]
        public void Setup()
        {    
            _basket = new Basket();
            _calculator = new Calculator(_basket, _discounts);
        }

        [Test]
        public void HasBasket()
        {
            var bread = new Product("bread", 1);
            _basket.Add(bread);

            Assert.IsNotNull(_basket);
            Assert.AreEqual("bread", bread.Name);
            Assert.AreEqual(1.00, bread.Value);
        }

        [Test]
        public void BasketTotals()
        {
            var bread = new Product("bread", 1);
            _basket.Add(bread);
            
            Assert.AreEqual(1.00, _calculator.Calculate());
        }

        [Test]
        public void ButterBreadDiscount()
        {
            var butter = new Product("butter", (decimal) 0.8);
            var bread = new Product("bread", (decimal) 1.00);
            _basket.Add(butter);
            _basket.Add(butter);
            _basket.Add(bread);
            _basket.Add(bread);

            Assert.AreEqual(3.10, _calculator.Calculate());
        }

        [Test]
        public void MilkDiscount()
        {
            var milk = new Product("milk", (decimal) 1.15);
            _basket.Add(milk);
            _basket.Add(milk);
            _basket.Add(milk);
            _basket.Add(milk);

            Assert.AreEqual(3.45, _calculator.Calculate());
        }
    }
}

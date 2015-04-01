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
        private Product _bread;
        private Product _milk;
        private Product _butter;

        [SetUp]
        public void Setup()
        {    
            _basket = new Basket();
            _calculator = new Calculator(_basket, _discounts);
            _bread = new Product("bread", 1);
            _milk = new Product("milk", (decimal) 1.15);
            _butter = new Product("butter", (decimal) 0.8);
        }

        [Test]
        public void HasBasket()
        {
            _basket.Add(_bread);

            Assert.IsNotNull(_basket);
            Assert.AreEqual("bread", _bread.Name);
            Assert.AreEqual(1.00, _bread.Value);
        }

        [Test]
        public void BasketTotals()
        {
            _basket.Add(_bread);
            
            Assert.AreEqual(1.00, _calculator.Calculate());
        }

        [Test]
        public void BreadButterMilk()
        {
            _basket.Add(_bread);
            _basket.Add(_butter);
            _basket.Add(_milk);
            Assert.AreEqual(2.95, _calculator.Calculate());
        }

        [Test]
        public void ButterBreadDiscount()
        {
            _basket.Add(_butter);
            _basket.Add(_butter);
            _basket.Add(_bread);
            _basket.Add(_bread);

            Assert.AreEqual(3.10, _calculator.Calculate());
        }

        [Test]
        public void MilkDiscount()
        {
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);

            Assert.AreEqual(3.45, _calculator.Calculate());
        }

        [Test]
        public void TwoButterOneBreadEightMilk()
        {
            _basket.Add(_butter);   
            _basket.Add(_butter);
            _basket.Add(_bread);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);
            _basket.Add(_milk);

            Assert.AreEqual(9.00, _calculator.Calculate());
        }
    }
}

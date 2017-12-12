using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter6.Domain.Models;

namespace Chapter6.Tests
{
    /// <summary>
    /// Summary description for LinqValueCalculatorTest
    /// </summary>
    [TestClass]
    public class LinqValueCalculatorTest
    {

        List<Product> _products;

        public LinqValueCalculatorTest()
        {
            _products = new List<Product>();
            _products.Add(new Product() { Name = "Tonys Kayak", Price = 10 });
            _products.Add(new Product() { Name = "Tonys Snooker Table", Price = 12 });
            _products.Add(new Product() { Name = "Tonys Pigeon Hole", Price = 13 });
            _products.Add(new Product() { Name = "Tonys Cricket bat", Price = 14 });
            _products.Add(new Product() { Name = "Tonys Basket ball", Price = 15 });
            _products.Add(new Product() { Name = "Tonys Batminton bat", Price = 16 });
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        [TestMethod]
        public void IsSumThe_Same_With_Dummy_Discounter()
        {
            //Arrange
            IDiscountCalculator calc = GetDiscounter(0);
            LinqValueCalculator linqCalc = new LinqValueCalculator(calc);


            //Act
            decimal finalPrice =  linqCalc.GetTotalValueOfProducts(_products);

            //Assert
            Assert.AreEqual(80, finalPrice);
        }


        [TestMethod]
        public void IsSumThe_Same_With_Dummy_Discounter_Return_Value_For_10_Percentage_Discount()
        {
            //Arrange
            IDiscountCalculator calc = GetDiscounter(10);
            LinqValueCalculator linqCalc = new LinqValueCalculator(calc);


            //Act
            decimal finalPrice = linqCalc.GetTotalValueOfProducts(_products);

            //Assert
            Assert.AreEqual(72, finalPrice);
        }



        private IDiscountCalculator GetDiscounter(decimal discountInPercentage)
        {
            Moq.Mock<IDiscountCalculator> calc = new Moq.Mock<IDiscountCalculator>();
            calc.Setup(o => o.GetDiscountedValue(Moq.It.IsAny<Decimal>())).Returns<decimal>(o => o * ((100-discountInPercentage)/100));
            return calc.Object;
        }
    }
}

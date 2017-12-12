using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter6.Domain.Models;

namespace Chapter6.Tests
{
    [TestClass]
    public class DiscounterTests
    {
        [TestMethod]
        public void Apply_Default_Discount_For_Amount_Of_100()
        {
            //Arrange
            IDiscountCalculator calc = GetDiscounter();

            //Act
            decimal finalPrice = calc.GetDiscountedValue(100);

            //Assert
            Assert.AreEqual(80, finalPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsException_When_Price_Less_Than_Zero()
        {
            //Arrange
            IDiscountCalculator calc = GetDiscounter();

            //Act
            decimal finalPrice = calc.GetDiscountedValue(-10);
           
        }



        private IDiscountCalculator GetDiscounter()
        {
            return new DiscountCalculator() { DiscountInPercentage = 80m };
        }

        
    }
}

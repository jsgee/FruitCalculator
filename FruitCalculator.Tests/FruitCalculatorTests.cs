using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FruitCalculator.Tests
{
    [TestClass]
    public class FruitCalculatorUnitTests
    {
        [TestMethod]
        public void SumTestNoDiscount()
        {
            var fc = new FruitCalculator();

            var fruitList = new List<Fruit>();

            fruitList.Add(new Fruit
            {
                Name = "oranges",
                price = 5,
                Quantity = 5
            });
            
            fruitList.Add(new Fruit
            {
                Name = "pears",
                price = .5M,
                Quantity = 10
            });

            var result = fc.Calculate(fruitList);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void SumTestWithDiscount()
        {
            var fc = new FruitCalculator();

            var fruitList = new List<Fruit>();

            fruitList.Add(new Fruit
            {
                Name = "oranges",
                price = 5,
                Quantity = 5,
                Discount = .5M
            });

            fruitList.Add(new Fruit
            {
                Name = "pears",
                price = .5M,
                Quantity = 10
            });

            var result = fc.Calculate(fruitList);

            Assert.AreEqual(17.5M, result);
        }
    }
}

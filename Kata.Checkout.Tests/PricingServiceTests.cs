using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.Checkout.Tests
{

    [TestFixture]
    public class PricingServiceTests
    {
        private PricingService pricingService;

        [SetUp]
        public void Setup()
        {
            List<Product> products = new List<Product>()
            {
                new Product('A', 50), new Product('B', 30), new Product('C', 20), new Product('D', 15)
            };

            pricingService = new PricingService(products);
        }

        [Test]
        public void GetPrice_ValidItem_ReturnsCorrectPrice()
        {
            // Arrange

            // Act
            int priceA = pricingService.GetPrice('A');
            int priceB = pricingService.GetPrice('B');
            int priceC = pricingService.GetPrice('C');
            int priceD = pricingService.GetPrice('D');

            // Assert
            Assert.AreEqual(50, priceA);
            Assert.AreEqual(30, priceB);
            Assert.AreEqual(20, priceC);
            Assert.AreEqual(15, priceD);
        }
    }

}

using NUnit.Framework;

namespace Kata.Checkout.Tests
{

    [TestFixture]
    public class CheckoutTests
    {
        private Checkout checkout;

        [SetUp]
        public void Setup()
        {


            checkout = new Checkout();
        }

        [Test]
        public void Scan_ValidItem_AddsItemToCart()
        {
            // Arrange
            char item = 'A';

            // Act
            checkout.Scan(item);

            // Assert
            Assert.AreEqual(1, checkout.GetItemCount(item));
        }

        [Test]
        public void GetTotalPrice_NoItemsInCart_ReturnsZero()
        {
            // Arrange

            // Act
            int totalPrice = checkout.GetTotalPrice();

            // Assert
            Assert.AreEqual(0, totalPrice);
        }

        [Test]
        public void GetTotalPrice_ItemsWithNoOffers_CalculatesTotalPrice()
        {
            // Arrange
            checkout.Scan('A');
            checkout.Scan('B');
            checkout.Scan('C');

            // Act
            int totalPrice = checkout.GetTotalPrice();

            // Assert
            Assert.AreEqual(100, totalPrice);
        }

        [Test]
        public void GetTotalPrice_ItemsWithOffers_CalculatesTotalPrice()
        {
            // Arrange
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('B');
            checkout.Scan('B');
            checkout.Scan('C');
            // Act
            int totalPrice = checkout.GetTotalPrice();

            // Assert
            Assert.AreEqual(6, checkout.GetCartItemCount());
            Assert.AreEqual(215, totalPrice);
        }
    }

}

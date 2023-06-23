using Kata.Checkout.Interfaces;

namespace Kata.Checkout
{
    public class Checkout : ICheckout
    {
        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void Scan(char item)
        {
            throw new NotImplementedException();
        }
    }
}
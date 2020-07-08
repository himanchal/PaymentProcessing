namespace PaymentProcessing
{
    class PaymentProcessor
    {
        public static bool ProcessPayment(Cart cart, User user)
        {
            foreach (IProduct product in cart.Product)
            {
                product.ProcessPayment(product, user);
            }
            return true;
        }
    }
}
 
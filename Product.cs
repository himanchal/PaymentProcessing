using System;

namespace PaymentProcessing
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool ProcessPayment(IProduct product, User user)
        {
            throw new NotImplementedException();
        }
    }
}
namespace PaymentProcessing
{
    public class DigitalProduct : IProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsEmailed { get; set; }
        public virtual bool ProcessPayment(IProduct product, User user)
        {
            //TO DO implementation for any generic digital product 
            return true;
        }
    }
}

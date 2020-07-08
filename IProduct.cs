namespace PaymentProcessing
{
    public interface IProduct
    {
        int Id { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        bool ProcessPayment(IProduct product, User user);
    }
}

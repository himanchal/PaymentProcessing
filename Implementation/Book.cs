using System;

namespace PaymentProcessing
{
    class Book : PhysicalProduct, IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string LicenseNo { get; set; }
        public int Pages { get; set; }
        public override bool ProcessPayment(IProduct product, User user)
        {
            Console.WriteLine("Book: generate a commission payment to the royalty department");
            return true;
        }
    }
}

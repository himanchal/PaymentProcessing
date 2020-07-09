using System;

namespace PaymentProcessing
{
    class PhysicalProduct : IProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }
        public bool IsShipped { get; set; }
        public virtual bool ProcessPayment(IProduct product, User user)
        {
            Console.WriteLine("physical product: generate a packing slip for shipping");
            Console.WriteLine("Generate a commision payment to the agent");
            return true;
        }
    }
    enum Color
    {
        Red, 
        Green,
        Blue,
        White,
        Black,
        NoColor
    }
}

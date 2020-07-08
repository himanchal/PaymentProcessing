using System.Collections.Generic;

namespace PaymentProcessing
{
    class Cart
    {
        public User User { get; set; }
        public List<IProduct> Product { get; set; }
    }
}

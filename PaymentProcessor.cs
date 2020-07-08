using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 
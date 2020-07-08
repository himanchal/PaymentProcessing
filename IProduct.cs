using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

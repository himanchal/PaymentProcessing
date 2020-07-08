using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing
{
    class Cart
    {
        public User User { get; set; }
        public List<IProduct> Product { get; set; }
    }
}

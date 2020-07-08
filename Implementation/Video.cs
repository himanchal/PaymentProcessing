using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing
{
    class Video : DigitalProduct, IProduct
    {
        public string Title { get; set; }
        public long SizeInMB { get; set; }
        public string Format { get; set; }
        public DateTime CreatedAt { get; set; }
        public override bool ProcessPayment(IProduct product, User user)
        {
            Console.WriteLine("Video Learning to ski: add free first aid video to the packing slip to the agent");
            return true;
        }
    }
}

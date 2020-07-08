using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing
{
    class Membership : DigitalProduct, IProduct
    {
        public MembershipType Type { get; set; }
        public int DurationInMonths { get; set; }
        public override bool ProcessPayment(IProduct product, User user)
        {
            if (user.MembershipType == MembershipType.Silver)
            {
                user.MembershipType = MembershipType.Gold;
                Console.WriteLine($"membership upgraded to Gold, sending mail to {user.Email}");
            }
            else if (user.MembershipType == MembershipType.Gold)
            {
                user.MembershipType = MembershipType.Plantinum;
                Console.WriteLine($"membership upgraded to Plantinum, sending mail to {user.Email}");
            }
            return true;
        }
    }
}

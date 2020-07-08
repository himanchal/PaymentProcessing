using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public MembershipType MembershipType { get; set; }
    }

    public enum MembershipType
    {
        Silver, 
        Gold,
        Plantinum
    }
}
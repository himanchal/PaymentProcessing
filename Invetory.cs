using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing
{
    public static class Inventory
    {
        public static List<IProduct> GetProducts()
        {
            List<IProduct> products = new List<IProduct>
            {
                new DigitalProduct
                {
                    Id = 1,
                    Description = "digitalProduct1",
                    IsEmailed = false,
                    Price = 125.41
                },
                new PhysicalProduct
                {
                    Id = 1,
                    Description = "physicalProduct1",
                    IsShipped = false,
                    Price = 1210.00
                },
                new Book
                {
                    Id = 12541,
                    Author = "Mr Author",
                    LicenseNo = "XASEW232",
                    Pages = 1542,
                    Price = 100,
                    IsShipped = false,
                    Color = Color.NoColor,
                    Description = "some description by author",
                    Title = "SomeTitle"
                },
                new Video
                {
                    Id = 12346,
                    Title = "Video1",
                    Description = "Some description by director",
                    CreatedAt = DateTime.Now,
                    SizeInMB = 52145,
                    Format = "mp4",
                    IsEmailed = false,
                    Price = 154
                },
                new Membership
                {
                    Id = 123456,
                    Type = MembershipType.Silver,
                    Description = "initial grade",
                    DurationInMonths = 24,
                    Price = 1044,
                    IsEmailed = true
                }
            };
            return products;
        }
    }
}

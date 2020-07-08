using System;

namespace PaymentProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maersk Order processing system");
            var user = new User() //based on the user login user object would be instantiated
            {
                Id = 2001,
                Email = "user1@gmail.com",
                Name = "user1",
                MembershipType =  MembershipType.Gold
            };
            var cart = new Cart() //building the cart manually 
            {
                User = user,
                Product = Inventory.GetProducts() //here items will be added to the cart
            };
            PaymentProcessor.ProcessPayment(cart, user); //shipping/processing the user's cart.
            Console.ReadLine();
        }
    }
}

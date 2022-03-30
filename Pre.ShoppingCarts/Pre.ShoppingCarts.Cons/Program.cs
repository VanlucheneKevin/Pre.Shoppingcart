using System;
using Pre.ShoppingCarts.Core.Entities;

namespace Pre.ShoppingCarts.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Product item1 = new Product("schoen", 15);
            Product item2 = new Product("laars", 20);
            Console.WriteLine(item2);

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(item1);
            shoppingCart.AddItem(item2);
            Console.WriteLine($"De totale prijs van het winkelmandje is {shoppingCart.CalculateTotal()} euro.");

            CreditCardStrategy creditcard = new CreditCardStrategy("KBC", "5555","367", DateTime.Now );
            shoppingCart.Pay(creditcard);



            
        }
    }
}

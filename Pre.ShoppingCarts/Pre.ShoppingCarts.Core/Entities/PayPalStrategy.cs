using Pre.ShoppingCarts.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.ShoppingCarts.Core.Entities
{
    public class PayPalStrategy : IPaymentStrategy
    {
        private string email;

        public PayPalStrategy(string email)
        {
            this.email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Ik heb betaald via PayPal");
        }
    }
}

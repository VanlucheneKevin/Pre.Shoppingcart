using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre.ShoppingCarts.Core.Interfaces;

namespace Pre.ShoppingCarts.Core.Entities
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        private string name;
        private string cardNumber;
        private string cvv;
        private DateTime dateOfExpiry;

        public CreditCardStrategy(string name, string cardNumber, string cvv, DateTime dateOfExpiry)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.dateOfExpiry = dateOfExpiry;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Ik heb betaald met Creditcard");
        }
    }
}

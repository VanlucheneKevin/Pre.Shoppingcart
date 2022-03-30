using Pre.ShoppingCarts.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.ShoppingCarts.Core.Entities
{
    public class CryptoStrategy : IPaymentStrategy
    {
        private string tickerSymbol;
        private string walletAddress;

        public CryptoStrategy(string tickerSymbol, string walletAddress)
        {
            this.tickerSymbol = tickerSymbol;
            this.walletAddress = walletAddress;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Ik heb betaald met cryptomunten");
        }
    }
}

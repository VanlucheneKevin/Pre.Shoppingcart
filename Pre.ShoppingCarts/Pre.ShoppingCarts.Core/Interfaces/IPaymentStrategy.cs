using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.ShoppingCarts.Core.Interfaces
{
    public interface IPaymentStrategy
    {
        public void Pay(decimal amount);
        
    }
}

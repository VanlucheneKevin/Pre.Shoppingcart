using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre.ShoppingCarts.Core.Interfaces;

namespace Pre.ShoppingCarts.Core.Entities
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product item)
        {
            items.Add(item);
        }

        public void RemoveItem(Product item)
        {
            items.Remove(item);
        }

        public decimal CalculateTotal()
        {
            decimal totalPrice = 0;
            foreach (Product item in items)
            {
                decimal pricePerItem = item.Price;
                totalPrice += pricePerItem;
            }
            return totalPrice;
        }

        public void Pay(IPaymentStrategy paymentStrategy)
        {
           
            paymentStrategy.Pay(CalculateTotal());
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ShopCart
    {
        /// <summary>
        /// List of items present in the cart
        /// </summary>
        private readonly List<CartItem> _items;
        public ShopCart()
        {
            _items = new List<CartItem>();
        }
        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }
        public void RemoveItem(CartItem item)
        {
            _items.Remove(item);
        }
        public List<CartItem> GetItems()
        {
            return _items;
        }
        public void Clear()
        {
            _items.Clear();
        }
        public int TotalCartAmount()
        {
            int total = 0;
            foreach (CartItem item in _items)
            {
                total += item.GetPrice();
            }
            return total;
        }
        public string Checkout(IPayment paymentMethod)
        {
            int amount = TotalCartAmount();
            if (amount == 0)
            {
                return "Cart is empty!";
            }
            string checkoutReturn = "";
            checkoutReturn += paymentMethod.Pay(amount);
            _items.Clear();
            return checkoutReturn;
        }
    }
}

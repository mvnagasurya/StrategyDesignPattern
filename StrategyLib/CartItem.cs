using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CartItem
    {
        private readonly string _itemName;
        private readonly int _itemPrice;
        public CartItem(string name, int price)
        {
            _itemName = name;
            _itemPrice = price;
        }

        /// <summary>
        /// Returns the Name of item
        /// </summary>
        public string GetName()
        {
            return _itemName;
        }

        /// <summary>
        /// Returns the price of the item
        /// </summary>
        public int GetPrice()
        {
            return _itemPrice;
        }
    }
}

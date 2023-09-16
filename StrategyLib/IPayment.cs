using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public interface IPayment
    {
        /// <summary>
        /// This is a common function present in both CreditCard payment Strategy and UPI Payment Strategy
        /// </summary>
        /// <param name="amount"></param>
        public string Pay(int amount);
    }
}

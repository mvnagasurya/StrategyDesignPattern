using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    /// <summary>
    /// Paypal using Email Payment Strategy
    /// </summary>
    public class PaypalEmail : IPayment
    {
        private readonly string _emailId;
        private readonly string _password;
        public PaypalEmail(string emailId, string password)
        {
            _emailId = emailId;
            _password = password;
        }
        /// <summary>
        /// Payment function through Paypal
        /// </summary>
        /// <param name="amount"></param>
        public string Pay(int amount)
        {
            return $"An amount of {amount} has been paid with through UPI\nThank you for the purchase!";
        }
    }
}

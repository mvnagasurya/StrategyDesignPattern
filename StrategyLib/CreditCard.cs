using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CreditCard : IPayment
    {
        private readonly string _holderName;
        private readonly string _cardNumber;
        private readonly string _cvv;
        private readonly string _dateOfExpiry;
        public CreditCard(string name, string cardNumber, string cVV, string dateOfExpiry)
        {
            _holderName = name;
            _cardNumber = cardNumber;
            _cvv = cVV;
            _dateOfExpiry = dateOfExpiry;
        }
        /// <summary>
        /// Checks if the card is valid or expired
        /// </summary>
        public bool CardValidity()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return string.Compare(_dateOfExpiry, dateTime.ToString("MM/yyyy")) < 0;
            //return true;
        }

        /// <summary>
        /// Payment function through Credit Card
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>A String displaying the amount paid</returns>
        public string Pay(int amount)
        {
            if (CardValidity())
            {
                return $"An amount of {amount} has been paid with Credit/Debit Card\nThank you for the purchase!";
            }
            else
            {
                return "Card Expired!";
            }
        }
    }
}

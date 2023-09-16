using System;
using StrategyDesignPattern;
namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            ShopCart cart = new ();
            CartItem item1 = new ("Lays", 20);
            CartItem item2 = new ("Sprite", 20);
            CartItem item3 = new ("GoodDay", 30);
            cart.AddItem(item1);
            cart.AddItem(item2);
            cart.AddItem(item3);

            // Testing the "TotalCartAmount" function
            Assert.AreEqual( cart.TotalCartAmount(),70);

            IPayment payment2 = new CreditCard("", "", "", "");
            // Testing the payment through Credit/Debit Card
            Assert.AreEqual(cart.Checkout(payment2), "An amount of 70 has been paid with Credit/Debit Card\nThank you for the purchase!");
        }
    }
}

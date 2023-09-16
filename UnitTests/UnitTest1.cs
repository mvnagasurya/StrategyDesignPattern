using System;
using StrategyDesignPattern;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
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

            // Testing the Payment through UPI
            IPayment payment1 = new PaypalEmail("surya@gmail.com", "surya");
            Assert.AreEqual(cart.Checkout(payment1), "An amount of 70 has been paid with through UPI\nThank you for the purchase!");

            cart.Clear();
            int size=cart.GetItems().Count;
            // Testing the cart "clear" function
            Assert.AreEqual(size, 0);
            // Testing payment after clearing the cart
            Assert.AreEqual(cart.Checkout(payment1), "Cart is empty!");
        }
    }
}

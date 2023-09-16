using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using StrategyDesignPattern;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteToConsole("Strategy Design Pattern", ConsoleColor.Cyan);
            ShopCart cart = new ();
            CartItem item1 = new ("Lays", 20);
            CartItem item2 = new ("Sprite", 20);
            CartItem item3 = new ("GoodDay", 30);
            cart.AddItem(item1);
            cart.AddItem(item2);
            cart.AddItem(item3);
            Console.WriteLine("Total Price: Rs." + cart.TotalCartAmount());
            IPayment payment1 = new PaypalEmail("cool@gmail.com", "hello");
            List<CartItem> items = cart.GetItems();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].GetName() + " " + items[i].GetPrice());
            }
            Console.WriteLine(cart.Checkout(payment1));
        }
        private static void WriteToConsole(string title, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor consoleForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(title);
            Console.ForegroundColor = consoleForegroundColor;
        }
    }
}

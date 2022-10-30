using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    public class Program
    {
        static void Main()
        {
            Customer john = new Customer();
            Menu menu = new Menu();

            john.OrderReady(new[] {Burger.price, Drink.price, Icecream.price}, 20);
        }
    }
}
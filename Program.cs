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
            Customer customer1 = new Customer("Brock");
            Lettuce lettuce = new Lettuce(0.20f, 4);
            Burger burger = new Burger();
            Menu menu = new Menu();
            

            Console.WriteLine(lettuce.price);
            Console.WriteLine(Burger.burgerPrice);

           
          
        }
    }
}
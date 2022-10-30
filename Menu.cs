using ChickenShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    class Menu
    {

    }
 
    class Burger : Menu
    {
        public static int price = 5;
        public static int buns = 3;
        public static int beef = 1;
        public static int lettuce = 2;
        public static bool orderReady = (buns > 1 && beef > 0 && lettuce > 0);

        public static void CheckIngredients()
        {
            if (orderReady)
            {
                Shop.MakeOrder();
            } 
            else
            {
                Console.WriteLine("Sorry, we do not have the ingredients ready to make that order.");
            }
        }
    }

    class Drink : Menu
    {
        public static int price = 3;
        public static int cup = 1;
        public static int sugar = 1;
        public static bool orderReady = (cup > 0 && sugar > 0);
        public static void CheckIngredients()
        {
            if (orderReady)
            {
                Shop.MakeOrder();
            }
            else
            {
                Console.WriteLine("Sorry, we do not have the ingredients ready to make that order.");
            }
        }
    }
}
    class Chips : Menu
    {
        public static int price = 4;
        public static int potato = 2;
        public static int salt = 1;
        public static bool orderReady = (potato > 1 && salt > 0);

    public static void CheckIngredients()
    {
        if (orderReady)
        {
            Shop.MakeOrder();
        }
        else
        {
            Console.WriteLine("Sorry, we do not have the ingredients ready to make that order.");
        }
    }
}
    
    class Icecream : Menu
    {
        public static int price = 4;
        public static int cream;
        public static int cone;
        public static bool orderReady = (cream > 1 && cone > 0);

    public static void CheckIngredients()
    {
        if (orderReady)
        {
            Shop.MakeOrder();
        }
        else
        {
            Console.WriteLine("Sorry, we do not have the ingredients ready to make that order.");
        }
    }
}
    


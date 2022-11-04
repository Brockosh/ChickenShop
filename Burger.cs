using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    public class Burger : Item
    {
        static public float burgerPrice = ((Bun.bunPrice * 2) + Cheese.cheesePrice + Meat.meatPrice);
    }
}

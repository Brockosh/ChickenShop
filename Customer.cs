using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    internal class Customer
    {
       
        public void OrderReady(int[] order, int money)
        {

            if (money >= order.Sum())
            {
                //Need to figure out how to properly create a CheckIngredients method to be used here.
            }
            else
            {
                Console.WriteLine("You do not have enough money for that order."); 
            }

        }
    }
}

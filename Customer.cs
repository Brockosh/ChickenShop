using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    internal class Customer
    {
        public string name;
        public void requestOrder(int[] order, object money)
        {
            money = money
 
            if ( >= order.Sum())
            {
                //Need to figure out how to properly create a CheckIngredients method to be used here.
            }
            else
            {
                Console.WriteLine("You do not have enough money for that order."); 
            }

        

        }

        public Customer(string name)
        {
            this.name = name;
        }



    }
}

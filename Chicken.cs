using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    internal class Chicken : Ingredients
    {
        public Chicken(float price, int quantity)
          : base(price, quantity)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShop
{
    internal class Lettuce : Ingredients
    {
        public Lettuce(float price, int quantity)
            : base(price, quantity)
        {
        }
    }
}

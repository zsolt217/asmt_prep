using Kitchen.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Ingredients
{
    internal class Patty : Ingredient, ICookAble
    {
        public int CookingTime => 1000;

        public Patty()
        {
            PreparationTime = 100;
        }
    }
}

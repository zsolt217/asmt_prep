using Kitchen.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Ingredients
{
    internal class Fries : Ingredient, ICookAble
    {
        public int CookingTime => 2000;

        public Fries()
        {
            PreparationTime = 100;
        }
    }
}

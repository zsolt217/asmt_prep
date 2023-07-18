using Kitchen.Common;
using Kitchen.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Hamburgers
{
    internal class NakedBurger : BaseBurger
    {
        public NakedBurger()
        {
            Ingrediens = new List<Ingredient> { new Patty(), new Lettuce(), new Tomato(), new Ketchup() };
        }
    }
}

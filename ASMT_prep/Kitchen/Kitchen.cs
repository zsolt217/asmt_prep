using Kitchen.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Kitchen
    {
        private Cook cook;
        private Oven oven;

        public Kitchen()
        {
            cook= new Cook();
            oven = new Oven();
        }

        public void HandleOrder(List<Ingredient> ingredients)
        {
            var forCooking = ingredients.Where(x => x.GetType() == typeof(ICookAble));
            var notForCooking = ingredients.Where(x => x.GetType() != typeof(ICookAble));

            List<Ingredient> actualCook;

            //Max Count-ig elmenni egy fajtából
            //Prepare
            //Cook
            //Prepare
            //Cook
            //Ha nincs több prepare for cooking akkor a sima prepare


        }

    }
}

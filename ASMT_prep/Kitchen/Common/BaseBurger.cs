using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Common
{
    public abstract class BaseBurger
    {
        public List<Ingredient> Ingrediens { get; protected internal set; }
    }
}

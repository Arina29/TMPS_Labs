using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public abstract class CookStrategy
    {
        public abstract void Cook(string food);

    }

    class NeapolitanStylePizza : CookStrategy
    {
        public override void Cook(string name)
        {
            Console.WriteLine("Cooking " + name +" with  a soft crisp crust");
        }
    }

    class NewYorkStylePizza : CookStrategy
    {
        public override void Cook(string name)
        {
            Console.WriteLine("Cooking "+ name +" pizza with large hand-tossed thin crust");
        }
    }
    
}

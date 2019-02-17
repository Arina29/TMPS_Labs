using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public sealed class Franchise
    {
        private Franchise()
        {
        }

        public static Franchise Instance { get; } = new Franchise();

        public IPizzaNetwork PizzaNetwork { get; } = new PizzaNetwork();
    }
}

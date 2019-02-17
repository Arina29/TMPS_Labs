using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public interface IPizzaNetwork
    {
        AndysPizzaStore GetAndysPizzaStore();
        CorsoPizzaStore GetCorsoPizzaStore();
    }

    public class PizzaNetwork : IPizzaNetwork
    {
        public CorsoPizzaStore GetCorsoPizzaStore() =>new CorsoPizzaStore();

        AndysPizzaStore IPizzaNetwork.GetAndysPizzaStore() => new AndysPizzaStore();


    }
}

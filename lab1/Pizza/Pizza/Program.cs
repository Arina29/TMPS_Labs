using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var AndysStore = Franchise.Instance.PizzaNetwork.GetAndysPizzaStore();
            var CorsoStore = Franchise.Instance.PizzaNetwork.GetCorsoPizzaStore();
            Console.WriteLine("--------------------------------------------");
            var a = AndysStore.OrderPizza("Cheese");
            Console.WriteLine("--------------------------------------------");
            var b = CorsoStore.OrderPizza("Neapolitana");
            Console.WriteLine("--------------------------------------------");
            var c = AndysStore.OrderPizza("Neapolitana");

            var clonedPizzaList = new List<Pizza>()
            {
                a.Clone(),
                b.Clone(),
                c.Clone()
            };

            foreach (var pizza in clonedPizzaList)
                Console.WriteLine(pizza.GetName());
            
            Console.ReadKey();
        }
    }
}

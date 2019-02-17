using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public interface IIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
    }

    public class Dough
    {

    }

    public class Sauce
    {

    }

    public class Cheese
    {

    }


    public class AndysIngredientFactory : IIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Create Andys Cheese");
            return new Cheese();
        }

        public Dough createDough()
        {
            Console.WriteLine("Create Andys Dough");
            return new Dough();
        }

        public Sauce createSauce()
        {
            Console.WriteLine("Create Andys Sauce");
            return new Sauce();
        }

    }

    public class CorsoIngredientFactory : IIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Create Corso Cheese");
            return new Cheese();
        }

        public Dough createDough()
        {
            Console.WriteLine("Create Corso Dough");
            return new Dough();
        }

        public Sauce createSauce()
        {
            Console.WriteLine("Create Corso Sauce");
            return new Sauce();
        }
    }
}

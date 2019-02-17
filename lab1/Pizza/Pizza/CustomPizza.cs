using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class AndysCheesePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public AndysCheesePizza(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Andys 4 cheese pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Parmezano cheese");
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom cheese pizza");
            ingredientFactory.createDough();
            ingredientFactory.createSauce();
            ingredientFactory.createCheese();
        }

        public override void Cut()
        {
            Console.WriteLine("Cut into square slices");
        }

        public override Pizza Clone()
        {
            Console.WriteLine("-----------CLONE PIZZA-----------");
            return  this.MemberwiseClone() as Pizza;
        }
    }

    class AndysNeapolitana : Pizza
    {
        IIngredientFactory ingredientFactory;

        public AndysNeapolitana(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Andys Neapolitana Pizza";
            dough = "Thin Crust Dough";
            sauce = "Bruschetta Sauce";
            toppings.Add("Reggiano cheese");
            toppings.Add("Garlic");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Neapolitana pizza at Andys");
            ingredientFactory.createDough();
            ingredientFactory.createSauce();
            ingredientFactory.createCheese();
        }

        public override void Cut()
        {
            Console.WriteLine("Cut into diagonal and square slices");
        }

        public override Pizza Clone()
        {
            return this.MemberwiseClone() as Pizza;
        }


    }

    class CorsoNeapolitana : Pizza
    {
        IIngredientFactory ingredientFactory;

        public CorsoNeapolitana(IIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
            name = "Corso Neapolitana Pizza";
            dough = "Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Parmezan cheese");
            toppings.Add("Tomato");
        }

        public override Pizza Clone()
        {
            return this.MemberwiseClone() as Pizza;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preapring Neapolitana Pizza at Corso");
            ingredientFactory.createDough();
            ingredientFactory.createSauce();
            ingredientFactory.createCheese();
        }

        public override void Bake()
        {
            Console.WriteLine("Bake 20 minutes on fire!");
        }
    }
}

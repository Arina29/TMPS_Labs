using System;

namespace Pizza
{
    public abstract class PizzaStore
    {
        
        public Pizza OrderPizza(String type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        //It has the responsability for creating the pizza
        protected abstract Pizza CreatePizza(String type);
    }

    public class AndysPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory = new AndysIngredientFactory();

            if (type == "Cheese")
                pizza = new AndysCheesePizza(ingredientFactory);
            else if (type == "Neapolitana")
                pizza = new AndysNeapolitana(ingredientFactory);

            return pizza;
        }
    }

    public class CorsoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory = new CorsoIngredientFactory();

            if (type == "Neapolitana")
                pizza = new CorsoNeapolitana(ingredientFactory);

            return pizza;
        }


    }
}

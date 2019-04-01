using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public enum Ingredients{
        Tomato , Focaccia, Rucola, Olives, Mushrooms, ChickenFillet, RedPepper, Mozarella,  Paprika, Salami, OliveOil, Ham
    }

    public abstract class PizzaTemplate
    {
        public List<Ingredients> ingredients { get; set; }

        public abstract void GetIngredients();

        public abstract void Bake();

        public void Slice()
        {
            Console.WriteLine("Slicing pizza in triangular pieces");
        }

        public void Cook()
        {
            GetIngredients();
            Bake();
            Slice();
        }
    }

    public class Neapolitana : PizzaTemplate
    {

        public override void Bake()
        {
            Console.WriteLine("Bake 30 minutes at 180 degrees Celsius");
        }

        public override void GetIngredients()
        {
            List<Ingredients> ingredients = new List<Ingredients>()
            {
                Food.Ingredients.Olives,
                Food.Ingredients.OliveOil,
                Food.Ingredients.Mozarella,
                Food.Ingredients.Tomato
            };
            foreach (var item in ingredients)
            {
               Console.WriteLine("Add:\t" + item);
            }
        }
    }


    public class Capricioasa : PizzaTemplate
    {

        public override void Bake()
        {
            Console.WriteLine("Bake 40 minutes at 180 degrees Celsius");
        }

        public override void GetIngredients()
        {
            List<Ingredients> ingredients = new List<Ingredients>()
            {
                Food.Ingredients.Mushrooms,
                Food.Ingredients.OliveOil,
                Food.Ingredients.Mozarella,
                Food.Ingredients.Focaccia
            };
            foreach (var item in ingredients)
            {
                 Console.WriteLine("Add:\t" + item);
            }
        }
    }


    public class Diablo : PizzaTemplate
    {

        public override void Bake()
        {
            Console.WriteLine("Bake 35 minutes at 160 degrees Celsius");
        }

        public override void GetIngredients()
        {
            List<Ingredients> ingredients = new List<Ingredients>()
            {
                Food.Ingredients.RedPepper,
                Food.Ingredients.Paprika,
                Food.Ingredients.Mozarella,
                Food.Ingredients.Mushrooms
            };
            foreach (var item in ingredients)
            {
                 Console.WriteLine("Add:\t" + item);
            }
        }
    }


    public class Rancho : PizzaTemplate
    {
   
        public override void Bake()
        {
            Console.WriteLine("Bake 42 minutes at 150 degrees Celsius");
        }

        public override void GetIngredients()
        {
            List<Ingredients> ingredients = new List<Ingredients>()
            {
                Food.Ingredients.RedPepper,
                Food.Ingredients.OliveOil,
                Food.Ingredients.Mozarella,
                Food.Ingredients.ChickenFillet
            };

            foreach (var item in ingredients)
            {
                Console.WriteLine("Add:\t" + item);
            }
        }
    }
}

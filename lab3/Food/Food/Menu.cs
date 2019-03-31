using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class Pizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Pizza(string name, decimal price )
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Amount: " + Amount);
        }
    }

    public interface IFoodCollection
    {
        PizzaIterator CreateIterator();
    }

    public class FoodCollection : IFoodCollection
    {
        private ArrayList _items = new ArrayList();

        public PizzaIterator CreateIterator()
        {
            return new PizzaIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value);  }
        }
    }

    public interface IPizzaIterator
    {
        Pizza First();
        Pizza Next();
        bool IsDone { get; }
        int ItemIndex { get; }
        Pizza CurrentPizza { get; }
    }

    public class PizzaIterator : IPizzaIterator
    {
        private FoodCollection _pizzas;
        private int _current = 0;
        private int step = 1;

        public PizzaIterator(FoodCollection pizzas)
        {
            _pizzas = pizzas;
        }

        public Pizza First()
        {
            _current = 0;
            return _pizzas[_current] as Pizza;
        }

        public Pizza CurrentPizza
        {
            get { return _pizzas[_current] as Pizza; }
        }

        public Pizza Next()
        {
            _current += step;
            if (!IsDone)
            {
                return _pizzas[_current] as Pizza;
            }

            return null;
        }

        public bool IsDone
        {
            get
            {
                return _current >= _pizzas.Count;
            }
        }

        public int ItemIndex
        {
            get { return _current; }
        }
    }
}

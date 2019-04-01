using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class Order
    {
        public List<Pizza> PizzaItems { get; set; }
        private int _pizzaCount { get; set; }

        public Order()
        {
            PizzaItems = new List<Pizza>();
        }

        public void ExecuteCommand(ICommand command , Pizza item)
        {
            command.Execute(PizzaItems, item, item.Amount);
        }

        public void ShowOrder()
        {
            foreach (var item in PizzaItems)
            {
                item.Display();
            }
        }

        public void GetDiscount(Order order)
        {
            if (order.PizzaItems.Count >= 5)
            {
                Console.WriteLine("Congratulation you've got a discount of 5%");
            }
        }
    }

    public class Client
    {
        private Pizza _menuItem;
        private ICommand _command;
        public Order Order { get; set; }
        private int _pizzaCount;

        public Client()
        {
            _pizzaCount = 0;
            Order = new Order();
        }

        public void SetCommand(int commandOption)
        {
            _command = new CommandFactory().GetCommand(commandOption);    
        }

        public void SetMenuItem(Pizza pizzaItem)
        {
            _menuItem = pizzaItem;
        }

        public void ExecuteCommand()
        {
            Order.ExecuteCommand(_command, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            Order.ShowOrder();
        }

        public void Notify()
        {
            Order.GetDiscount(Order);
        }

        public int PizzaCount
        {
            get { return _pizzaCount; }
            set
            {
                if (Order.PizzaItems.Count >= value)
                {
                    _pizzaCount = value;
                    Notify();
                }
            }
        }

       
    }
}

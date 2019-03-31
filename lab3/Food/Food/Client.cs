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

        public Order()
        {
            PizzaItems = new List<Pizza>();
        }

        public void ExecuteCommand(ICommand command , Pizza item)
        {
            command.Execute(PizzaItems, item);
        }

        public void ShowOrder()
        {
            foreach (var item in PizzaItems)
            {
                item.Display();
            }
        }
    }

    public class Client
    {
        private Pizza _menuItem;
        private ICommand _command;
        private Order _order;

        public Client()
        {
            _order = new Order();
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
            _order.ExecuteCommand(_command, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowOrder();
        }
    }

    public class CommandFactory
    {
        public ICommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                default:
                    return new AddCommand();
            }
        }
}
}

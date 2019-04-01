using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public interface ICommand
    {
        void Execute(List<Pizza> order, Pizza pizzaItem, int amount);
    }

    public class AddCommand : ICommand
    {
        public void Execute(List<Pizza> order, Pizza pizzaItem, int amount )
        {
            for(var i = 0; i < amount; i++)
            {
                order.Add(pizzaItem);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public interface ICommand
    {
        void Execute(List<Pizza> order, Pizza pizzaItem);
    }

    public class AddCommand : ICommand
    {
        public void Execute(List<Pizza> order, Pizza pizzaItem)
        {
            order.Add(pizzaItem);
        }
    }
}

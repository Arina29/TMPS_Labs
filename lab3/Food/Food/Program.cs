using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    class Program
    {
        static FoodCollection Menu()
        {
            FoodCollection collection = new FoodCollection();
            collection[0] = new Pizza("Neapolitana", 80, new Neapolitana());
            collection[1] = new Pizza("Diablo", 80, new Diablo());
            collection[2] = new Pizza("Rancho", 70, new Rancho());
            collection[5] = new Pizza("Capricioasa", 85, new Capricioasa());

            Console.WriteLine("----------------------Menu---------------------");
            PizzaIterator iterator = collection.CreateIterator();
            for (Pizza item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(iterator.ItemIndex + 1 + ")" + item.Name + "\t" + item.Price + " mdl");
            }

            return collection;
        }

        static void Main(string[] args)
        {
            var collection = Menu();
            Console.WriteLine("--------Choose an action----------");
            Console.WriteLine("1-AddCommand");

            List<Client> clientOrders = new List<Client>();
            Client client = new Client();
            while (true)
            {
                Console.WriteLine("Do you want to create  order?Y/N");
                if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
                {
                    Console.WriteLine("Enter the pizza number:");
                    var commandPizza = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the amount:");
                    var amount = int.Parse(Console.ReadLine());

                    client.SetCommand(1);
                    var pizza = collection[commandPizza - 1] as Pizza;
                    pizza.Amount = amount;
                    pizza.Price = pizza.Amount * pizza.Price;
                    pizza.CookStrategy = new NeapolitanStylePizza();

                    client.SetMenuItem(pizza);
                    client.ExecuteCommand();
                    client.ShowCurrentOrder();
                    client.PizzaCount = client.Order.PizzaItems.Count;

                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

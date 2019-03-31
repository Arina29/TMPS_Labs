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
            FoodCollection colllection = new FoodCollection();
            colllection[0] = new Pizza("Neapolitana", 80);
            colllection[1] = new Pizza("Diablo", 80);
            colllection[2] = new Pizza("Rancho", 70);
            colllection[3] = new Pizza("Pepperoni", 80);
            colllection[4] = new Pizza("Margherita", 85);
            colllection[5] = new Pizza("Capricioasa", 85);

            Console.WriteLine("----------------------Menu---------------------");
            PizzaIterator iterator = colllection.CreateIterator();
            for (Pizza item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(iterator.ItemIndex + 1 + ")" + item.Name + "\t" + item.Price + " mdl");
            }

            return colllection;
        }

        static void Main(string[] args)
        {
            var collection = Menu();
            Console.WriteLine("--------Choose an action----------");
            Console.WriteLine("1-AddCommand");

            List<Client> clientOrders = new List<Client>();
            while (true)
            {
                Console.WriteLine("Do you want to create  order?");
                if (Console.ReadLine() == "Y")
                {
                    Client client = new Client();
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
                    clientOrders.Add(client);
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

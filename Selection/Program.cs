using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("What pizza topping would you like? ");
            string pizzaTopping = Console.ReadLine();

            if (pizzaTopping.ToLower() == "ham")
            {
                Console.WriteLine("Not suitable for vegetarians");
            }

            switch(pizzaTopping)
            {
                case "ham":
                case "pepperoni":
                case "chicken":
                    Console.WriteLine("Not suitable for vegetarians");
                    break;
                case "vegetables":
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for vegetarians");
                    break;
                default:
                    Console.WriteLine("Unknown pizza topping!");
                    break;
            }
        
        
        }
    }
}

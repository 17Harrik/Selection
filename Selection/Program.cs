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

            string pizzaTopping = Input("What pizza toppings would you like? ");

            switch(pizzaTopping.ToLower())
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

            string music = Input("What type of music do you like? ");
            switch(music.ToLower())
            {
                case "jazz":
                    Console.WriteLine("So... you like jazz?");
                    break;
                default:
                    Console.WriteLine("Nice!");
                    break;
                
                

            }
        
        
        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="question"> The question to ask </param>
        /// <returns> The answer to the question </returns>
        private static string Input(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
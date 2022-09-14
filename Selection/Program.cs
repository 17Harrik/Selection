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
                    Print("Not suitable for vegetarians", ConsoleColor.Green);
                    break;
                case "vegetables":
                case "cheese and tomato":
                case "margherita":
                    Print("Suitable for vegetarians", ConsoleColor.Red);
                    break;
                default:
                    Console.WriteLine("Unknown pizza topping!");
                    break;
            }

            string music = Input("What type of music do you like? ");
            switch (music.ToLower())
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
        ///  Displays a message in colour on the console
        /// </summary>
        /// <param name="output"></param>
        /// <param name="color"></param>
        private static void Print(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(output);

            Console.ResetColor();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Operations
    {
        public static void FindOp()
        {
            Console.WriteLine("Enter a character: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Console.WriteLine("Arithmetic operator.");
                    break;

                case "&&":
                case "||":
                    Console.WriteLine("Logical operator.");
                    break;

                case "==":
                case "<":
                case ">":
                    Console.WriteLine("Relational operator.");
                    break;
                case "?:":
                    Console.WriteLine("Conditional operator.");
                    break;

                default:
                    Console.WriteLine("Invalid.");
                    break;
            }
        }
    }
}

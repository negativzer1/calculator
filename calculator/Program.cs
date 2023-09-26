using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию, допустимые операции + - / *");
            string a = Console.ReadLine();
            switch (a)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("операция неопределена");
                    break;
            }
        }
    }
}

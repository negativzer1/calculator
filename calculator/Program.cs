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
// вынести реализацию в отдельный метод. в Main только его вызывать
            Console.WriteLine("введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
            Console.WriteLine("введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию, допустимые операции + - / *");// следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
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

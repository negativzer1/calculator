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
            calculator();
        }

        static void calculator()
        {
            char operation;
            double number1;
            double number2;
            inputnumber1(out number1);
            inputnumber2(out number2);
            inputoperation(out operation);
            switch (operation)
            {
                case '+':
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("Операция не определена");
                    break;
            }
        }
        private double inputnumber1(out double cnumber1)
        {
            Console.WriteLine("Введите первое число");
            string snumber1 = Console.ReadLine();
            if (double.TryParse(snumber1, out cnumber1))
            {
                return cnumber1;
            }
            else
            {
                Console.WriteLine("Ошибка, попробуйте снова");
                inputnumber1(out cnumber1);
                return cnumber1;
            }

        }
        private double inputnumber2(out double cnumber2)
        {
            Console.WriteLine("Введите второе число");
            string snumber2 = Console.ReadLine();
            if (double.TryParse(snumber2, out cnumber2))
            {
                return cnumber2;
            }
            else
            {
                Console.WriteLine("Ошибка, попробуйте снова");
                inputnumber2(out cnumber2);
                return cnumber2;
            }

        }
        private char inputoperation(out char coperation)
        {
            Console.WriteLine("Введите операцию, допустимые операции + - / *");
            string snumber2 = Console.ReadLine();
            if (char.TryParse(snumber2, out coperation))
            {
                if (coperation == '+' || coperation == '-' || coperation == '*' || coperation == '/')
                    return coperation;
                else
                {
                    Console.WriteLine("Ошибка, попробуйте снова");
                    inputoperation(out coperation);
                }
            }

            else
            {
                Console.WriteLine("Ошибка, попробуйте снова");
                inputoperation(out coperation);
                return coperation;
            }
            return coperation;
        }
    }
}

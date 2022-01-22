using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {

                    Console.WriteLine("Введите число 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите число корректное число");
                    Console.ReadLine();
                    continue;
                }



                Console.WriteLine(" + : сложение чисел");
                Console.WriteLine(" - : вычетание чисел");
                Console.WriteLine(" * : произведение чисел");
                Console.WriteLine(" / : частное чисел");
                Console.WriteLine();
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Черные дыры появились там, где Бог пытался делить на НОЛЬ. ");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Функционал ограничен");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
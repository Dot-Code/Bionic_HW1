using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.Write("Введiть число А та натиснiть Enter: ");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка. Ви ввели не число");
                Console.ReadKey();
                return;
            }

            Console.Write("Введiть число B та натиснiть Enter: ");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка. Ви ввели не число");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Щоб перемножити цi два числа натиснiть 1 та Enter");
            Console.WriteLine("Щоб подiлити число а на число b натиснiть 2 та Enter");
            Console.WriteLine("Щоб дiзнатись їхню суму натиснiть 3 та Enter");
            Console.WriteLine("Щоб дiзнатись їхню рiзницю натиснiть 4 та Enter");
            Console.WriteLine("Щоб вийти з програми натиснiть 5 та Enter");
            Console.WriteLine();

            string s3 = Console.ReadLine();
            Console.WriteLine();
            switch (s3)
            {
                case "1":
                    Multiply mul = new Multiply();
                    Console.WriteLine("Добуток = " + mul.Calculate(a, b));
                    Console.WriteLine(mul.Remainder(a, b));
                    break;
                case "2":
                    Divide div = new Divide();
                    Console.WriteLine("Результат дiлення = " + div.Calculate(a, b));
                    Console.WriteLine(div.Remainder(a, b));
                    break;
                case "3":
                    Add add = new Add();
                    Console.WriteLine("Сума = " + add.Calculate(a, b));
                    Console.WriteLine(add.Remainder(a, b));
                    break;
                case "4":
                    Subtract sub = new Subtract();
                    Console.WriteLine("Рiзниця = " + sub.Calculate(a, b));
                    Console.WriteLine(sub.Remainder(a, b));
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Жодної операцiї не обрано");
                    break;
            }
            Console.ReadKey();
        }
    }
}

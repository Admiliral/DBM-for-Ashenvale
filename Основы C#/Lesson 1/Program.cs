using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

          

            return;

            //double x = 10;
            //double y = 2;
            //double res = x / y;
            //Console.WriteLine(res); // 5


            //Console.WriteLine();

            //int a = 12345;
            //int o = a % 10; Console.WriteLine(o);
            //a = a / 10;
            
            //o = a % 10; Console.WriteLine(o);
            //a = a / 10;

            //o = a % 10; Console.WriteLine(o);
            //a = a / 10;

            //o = a % 10; Console.WriteLine(o);
            //a = a / 10;

            //o = a % 10; Console.WriteLine(o);
            //a = a / 10;

            //return;

            //int a = 11;
            //int b = 2;
            //Console.WriteLine(a / b); // 5
            //Console.WriteLine(a % b); // 1

            //double x = 11;
            //double y = 2;
            //Console.WriteLine(x / y); // 5,5



            //Example1();
            //Console.WriteLine();
            //Example2();

            End();
        }

        private static void Example2()
        {
            Console.WriteLine("Калькулятор v 1.1");

            Console.Write("Введите первое число  ");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число  ");
            int valueB = int.Parse(Console.ReadLine());

            int result = valueA + valueB;

            Console.WriteLine(valueA + " + " + valueB + " = " + result); // --
            Console.WriteLine(Convert.ToString(valueA) + " + " + Convert.ToString(valueB) + " = " + Convert.ToString(result)); // -+
            Console.WriteLine(valueA.ToString() + " + " + valueB.ToString() + " = " + result.ToString()); // +-
            Console.WriteLine("{0} + {1} = {2}", valueA, valueB, result); // ++
            Console.WriteLine(String.Format("{0} + {1} = {2}", valueA, valueB, result)); // +++
            Console.WriteLine($"{valueA} + {valueB} = {result}"); // ++
            Console.WriteLine("{valueA} + {valueB} = {result}"); // 
        }

        private static void End()
        {
            Console.WriteLine("Авторские права (с) Мои");
            Console.ReadKey();
        }

        private static void Example1()
        {
            Console.WriteLine("Программа - Привет, пользователь!");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!");

            //Console.ReadKey();
        }
    }
}

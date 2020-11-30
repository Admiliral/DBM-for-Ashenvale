using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 1. Написать метод, возвращающий минимальное из трех чисел.

            //Console.Write("Введите первое число ");
            //var a = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число ");
            //var b = int.Parse(Console.ReadLine());
            //Console.Write("Введите третье число ");
            //var c = int.Parse(Console.ReadLine());
            //int min = 0;

            //min = (a < b && a < c) ? a : (b < c) ? b : c;
            //Console.WriteLine(min);



            // Задача 2. Написать метод подсчета количества цифр числа.

            //Console.Write("Введите число");
            //var n = int.Parse(Console.ReadLine());

            //int num = (int)Math.Log10(n) + 1;
            //Console.WriteLine(num);



            // Задача 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            //Console.WriteLine("Введите целое число");
            //int count = 0;
            //int summ = 0;
            //var x = Convert.ToInt32(Console.ReadLine());
            //while ( x != 0 )
            //{
            //    count ++ ;
            //    if (x % 2 != 0)
            //    summ = summ + x;
            //    x = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Сумма нечетных, положительных чисел равна " + summ);

            // Задача 4

            String name = "root";
            String password = "GeekBrains";
            int z = 0;
            int i = 3;
            do
            {
                Console.WriteLine("Введите логин");
                var InputName = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var InputPassword = Console.ReadLine();
                if ( name == InputName && InputPassword == password)
                {
                    Console.WriteLine("Добро пожаловать, вы вошли с " + z + "попытки");
                    break;
                }
                else 
                    {
                    i--;
                    z++;
                    if (z < 3)
                    Console.WriteLine("Осталось попыток " + i + ", повторите попытку\n");
                    }
            }
            while (z < 3);
            Console.WriteLine("Количество попыток исчерпано");


















        }
    }
}

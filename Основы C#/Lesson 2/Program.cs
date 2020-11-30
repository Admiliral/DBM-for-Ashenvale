using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp8
{


    //     Указывает день недели.

    public enum MyDayOfWeek
    {
        Monday = 1,

        Tuesday = 2,

        Wednesday = 3,

        Thursday = 4,

        Friday = 5,

        Saturday = 6,

        Sunday = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            while (a <= 1000)
            {

                bool f = true;

                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        f = false;
                        break;
                    }
                }

                if (f) Console.Write($"{a} ");
                a++;
            }


            //Console.Write("введите a ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("введите b ");
            //var b = int.Parse(Console.ReadLine());
            //Console.Write("введите c ");
            //var c = int.Parse(Console.ReadLine());
            //int max = 0;



            //max = (a > b && a > c) ? a : (b > c) ? b : c;

            //if (a % 2 == 0) Console.WriteLine("да");
            //else Console.WriteLine("нет");


            //Console.WriteLine(a % 2 == 0 ? "да" : "нет");

            //if (a > b && a > c)
            //{
            //    max = a;
            //}
            //else
            //{
            //    //max = b > c ? b : c;

            //    if (b > c)
            //    {
            //        max = b; ;
            //    }
            //    else
            //    {
            //        max = c;
            //    }
            //}



            //Console.WriteLine(max);


            //GraphicsWindow.Show();

            //int pointAx = 10, pointAy = 200,
            //    pointBx = 200, pointBy = 10,
            //    pointCx = 310, pointCy = 200;

            ////GraphicsWindow.DrawRectangle(x1, y1, 2, 2);
            //GraphicsWindow.SetPixel(pointAx, pointAy, "Blue");
            //GraphicsWindow.SetPixel(pointBx, pointBy, "Blue");
            //GraphicsWindow.SetPixel(pointCx, pointCy, "Blue");
            //int x = pointAx, y = pointAy;
            //Random r = new Random();


            //GraphicsWindow.MouseDown += () =>
            // {
            //     for (int i = 0; i < 1000; i++)
            //     {
            //         switch (r.Next(3))
            //         {
            //             case 0: x = (x + pointAx) / 2; y = (y + pointAy) / 2; break;
            //             case 1: x = (x + pointBx) / 2; y = (y + pointBy) / 2; break;
            //             default: x = (x + pointCx) / 2; y = (y + pointCy) / 2; break;
            //         }
            //         GraphicsWindow.SetPixel(x, y, "Blue");
            //     }
            // };







            // 1 < a < 5

            //double a;

            //do
            //{
            //    Console.Write("Введите число 1 < a < 5  ");
            //    double.TryParse(Console.ReadLine(), out a);
            //} while (!(a > 1 && a < 5));
            //Console.WriteLine(a);

            //int t = 0;
            //int m = 1;
            //int i = 55;
            //if (i < 4) 
            //do
            //{
            //    Console.Write($"Введите {i + 1}-е число: ");
            //    var f = int.TryParse(Console.ReadLine(), out t);
            //    if (t != 0) m *= t;
            //    i = i + 1;
            //} while (i < 4);


            //int i = 0;
            //while (i < 4)
            //{
            //    Console.Write($"Введите {i + 1}-е число: ");
            //    var f = int.TryParse(Console.ReadLine(), out t);
            //    if (t != 0) m *= t;
            //    i = i + 1;
            //}

            //for (int i = 0; i < 10; i = i + 1)
            //{
            //    Console.Write($"Введите {i + 1}-е число: ");
            //    var f = int.TryParse(Console.ReadLine(), out t);
            //    if (t != 0) m *= t;
            //}


            //Console.WriteLine(m);


            #region _

            #endregion

            #region switch

            //Console.Write("Введиите число");
            //int day = 0;
            //string str = Console.ReadLine();
            //bool flag = int.TryParse(str, out day);

            //Console.WriteLine((MyDayOfWeek)day);




            //switch (day)
            //{
            //    case 1: Console.WriteLine("Пн"); break;
            //    case 2: Console.WriteLine("Вт"); break;
            //    case 3: Console.WriteLine("Ср"); break;
            //    case 4: Console.WriteLine("Чт"); break;
            //    default: Console.WriteLine("Такого дня нет"); break;
            //}


            //if (day == 1) Console.WriteLine("Пн"); 
            //else if (day == 2) Console.WriteLine("Вт");
            //else if (day == 3) Console.WriteLine("Ср");
            //else if (day == 4) Console.WriteLine("Чт");
            //else Console.WriteLine("Такого дня нет");



            //if(day == 1)
            //{
            //    Console.WriteLine("Пн");
            //}
            //else
            //{
            //    if (day == 2)
            //    {
            //        Console.WriteLine("Вт");
            //    }
            //    else
            //    {
            //        if (day == 3)
            //        {
            //            Console.WriteLine("Ср");
            //        }
            //        else
            //        {
            //            if (day == 4)
            //            {
            //                Console.WriteLine("Чт");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Такого дня нет");
            //            }

            //        }

            //    }

            //}


            #endregion

            #region if-else
            ////var a = 0;
            ////var s = Console.ReadLine();
            ////var f = int.TryParse(s, out a);

            ////if (f) Console.WriteLine("Это число");
            ////else Console.WriteLine("Это не число");

            ////Console.WriteLine(a);

            //Console.Write("введите a ");
            //var a = int.Parse(Console.ReadLine());
            //Console.Write("введите b ");
            //var b = int.Parse(Console.ReadLine());


            //if (a > b)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(a);
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //    Console.WriteLine(b);
            //    Console.WriteLine(b);
            //    Console.WriteLine(b);
            //}
            #endregion


        }
    }
}

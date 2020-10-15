using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;

            Console.WriteLine("Введите R: ");

            // там где программа не может посчитать число написано ( не число ) т.е. функция не определена
            if (!double.TryParse(Console.ReadLine(), out R))
            {
                Console.WriteLine("Ошибка! Требовалось ввести число!");
            }

            if (R == 0)
            {
                Console.WriteLine($"Центр окружности: {-8:0.0} {-2:0.0}");
            }

            if (R < 2)
            {
                Console.WriteLine("Функция не определена!");


            }

            for (double x = -10; x <= 8.2; x += 0.2)
            {
                if (x < -10)
                {
                    Console.WriteLine("Функция не определена!");
                }
                else if (x < -6)
                {
                    Console.WriteLine($"({Math.Round(x, 1)})({Math.Round(s_1(x, R), 1)})");

                }
                else if (x < 2)
                {
                    Console.WriteLine($"({Math.Round(x, 1)})({Math.Round(s_2(x, R), 1)})");

                }



                else if (x > 2 && x < 6)
                {



                    Console.WriteLine($"({Math.Round(x, 1)})({Math.Round(s_3(x, R), 1)})");

                }
                else if (x < 9)
                {
                    Console.WriteLine($"({Math.Round(x, 1)})({Math.Round(s_4(x, R), 1)})");
                }
            }
            Console.WriteLine("(2,2)(2,0)");


            // первый 
            static double s_1(double x, double radius)
            {

                double a = -8;
                double b = -2;
                double y;
                //  из уравнения окружности
                y = Math.Sqrt(radius * radius - (x - a) * (x - a)) + b;
                return y;
            }

            //второй
            static double s_2(double x, double radius)
            {
                double y = (0.5 * x) + 1;
                return y;
            }

            //третий
            static double s_3(double x, double radius)
            {
                double y = 0;
                return y;
            }
            //четвёртый
            static double s_4(double x, double radius)
            {
                double y = Math.Pow(x - 6, 2);
                return y;
            }



        }
    }
}
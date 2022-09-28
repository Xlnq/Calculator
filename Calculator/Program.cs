using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию которую хотите выполнить: ");
            Console.WriteLine("1) Cложение чисел");
            Console.WriteLine("2) Вычитание чисел");
            Console.WriteLine("3) Умножение чисел");
            Console.WriteLine("4) Деление чисел");
            Console.WriteLine("5) Возведения числа в степень N");
            Console.WriteLine("6) Квадратный корень числа");
            Console.WriteLine("7) Найти 1 процент от числа");
            Console.WriteLine("8) Факториал числа");
            Console.WriteLine("9) Выход из программы");

            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());

                if (i < 0 || i > 9)
                {
                    Console.WriteLine("Ошибка. Выберите корректную операцию!"); ;
                }

                if (i == 1)
                {
                    Console.WriteLine("Выберите первое число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите второе число:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ответ: "); Console.WriteLine(a + b);
                }

                if (i == 2)
                {
                    Console.WriteLine("Выберите первое число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите второе число:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ответ: "); Console.WriteLine(a - b);
                }

                if (i == 3)
                {
                    Console.WriteLine("Выберите первое число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите второе число:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ответ: "); Console.WriteLine(a * b);
                }

                if (i == 4)
                {
                    Console.WriteLine("Выберите первое число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите второе число:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка. Делитель не может быть равен 0!");
                    }

                    Console.WriteLine("Ответ: "); Console.WriteLine(a / b);
                }

                if (i == 5)
                {
                    Console.WriteLine("Выберите число: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Выберите степень: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    a = Math.Pow(a, b);
                    Console.WriteLine("Ответ: "); Console.WriteLine(a);
                }

                if (i == 6)
                {
                    Console.WriteLine("Выберите число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a < 0)
                    {
                        Console.WriteLine("Ошибка. Квадратный корень не может быть отрицательным!");
                    }
                    else
                    {
                        Console.WriteLine("Ответ: "); Console.WriteLine(Math.Sqrt(a));
                    }
                }

                if (i == 7)
                {
                    Console.WriteLine("Выберите число:");
                    double a = Convert.ToDouble(Console.ReadLine());

                    a = a / 100;

                    Console.WriteLine("Ответ: "); Console.WriteLine(a);
                }

                if (i == 8)
                {
                    int x = 1;
                    Console.WriteLine("Выберите число:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    for (int b = 1; b <= a; b++)
                    {
                        x = x * b;
                    }
                    Console.WriteLine(x);
                }

                if (i == 9)
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Повторно выберите операцию.");
            }
        }
    }
}
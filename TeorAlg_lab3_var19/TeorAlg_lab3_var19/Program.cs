using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TA_lab3_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выборка заданий: \n\tЧасть 1 - 1 \n\tЧасть 2 - 2 \n\tЧасть 3 - 3\nВыберете задание: ");
            switch (Console.ReadLine()) {
            case "1": Console.WriteLine("\nЧасть-1");
                double x = -4, y = 0, dx;
                Console.WriteLine("Таблица значений кусочной функции");
                Console.WriteLine("     ____________");
                Console.WriteLine("     |  x |   y |");
                Console.WriteLine("     |____|_____|");
                for (dx = 1; x < 9; x = x + dx)
                {
                    if (x < -1)
                        y = -(x + 1);
                    else if (-1 <= x && x <= 1)
                        y = 0;
                    else if (1 < x && x < 5)
                        y = Math.Sqrt(4 - Math.Pow((x - 3), 2));
                    else
                        y = -0.5 * x + 2.5;

                    Console.WriteLine("     |" + String.Format("{0,4:0.#}", x) + "|" + String.Format("{0,5:0.##}", y) + "|");
                    Console.WriteLine("     |____|_____|");
                }
          break;
          case "2": Console.WriteLine("\nЧасть-2");
            Double R;
            Console.WriteLine("Попадания в мишень");
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите R=");
                        R = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите x=");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите у=");
                        y = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException) { Console.WriteLine("\nОшибка формата данных данных\n"); continue; }
                    break;
                }
                if ((y <= 2 * R && x <= 2 * R && x >= 0 && !(y <= Math.Sqrt((R + x) * (R - x)))) || (x <= 0 && x >= -2 * R && y <= 0 && y <= 2 * R - x))
                    Console.WriteLine("Есть попадание!");
                else
                    Console.WriteLine("Мимо!");
            }
           break;
           case "3": Console.WriteLine("\nЧасть-3");
                Double ArcSin_x, ArcSin_x_Defect, x_begin = 0, x_end = 0;
                do
                {
                    try
                    {
                        Console.Write("Начало интервала х=");
                        x_begin = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Конец интервала х=");
                        x_end = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Шаг прохода по интервалу dx=");
                        dx = Convert.ToDouble(Console.ReadLine());
                        if (x_begin < -1 || x_end > 1 || dx > 2 || dx < 0) { Console.WriteLine("\nОшибка ввода данных: -1<x<1, dx<2\n"); continue; }
                    }
                    catch (FormatException) { Console.WriteLine("\nОшибка формата данных данных\n"); continue; }
                     break; //do {..break..}while (true);
                } while (true);
            Console.WriteLine("\n\tТаблица расчетов ряда Тейлора\n  для функции arcsin(x) при точности 0,0001");
            Console.WriteLine("     ________________________________");
            Console.WriteLine("     |   x |asin_def|   N |arcsin(x)|");
            Console.WriteLine("     |_____|________|_____|_________|");
            double e_defect = 0.0001;
            for (x = x_begin; x < x_end; x = x + dx)
            {
                ArcSin_x = Math.Asin(x);
                ArcSin_x_Defect = x; //ArcSin_x_Defect = x + last_Taylor_add; last_Taylor_add = NaN при n=0 
                int n = 1; /*Счетчик итераций нижеследующего цикла
                (количество итераций на 1 меньше т.к. первый член ряда лежит в ArcSin_x_Defect = x; */
                for (Double last_Taylor_add = 1; e_defect < Math.Abs(last_Taylor_add); n++) //last_Taylor_add=1 -> e_defect < 1 (100%)
                {
                    double fact_div = 1, fact_n = 1;                  
                    for (int i = n + 1; i <= 2 * n; i++) //fact_div = (2n)!/n! =(n+1)*(n+2)*...*(2n)
                    {
                        fact_div = fact_div * i;
                        fact_n = fact_n * (i-n);
                    }
                    last_Taylor_add = Math.Pow(x, 2 * n + 1) * fact_div / (Math.Pow(4, n) * (2 * n + 1) * fact_n); //Вычисление следущего члена ряда, при n=>1
                    ArcSin_x_Defect += last_Taylor_add;
                }

                Console.WriteLine("     |" + String.Format("{0,5:0.#}", x) + "|" + String.Format("{0,8:0.####}", ArcSin_x_Defect) + "|" + String.Format("{0,5:0}", n - 1) + "|" + String.Format("{0,9:0.####}", ArcSin_x) + "|");
                Console.WriteLine("     |_____|________|_____|_________|");
            }
                    break;
                default:
                    Console.WriteLine("\nМне не известно такое задание!");
                    break;
            }
            Console.WriteLine("\nВыполнение окончено.");
            Console.ReadKey(true);
        }
    }
}


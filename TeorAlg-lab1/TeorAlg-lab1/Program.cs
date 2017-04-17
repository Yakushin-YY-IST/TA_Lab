using System;
using System.Collections.Generic;
using System.Text;

namespace TeorAlg_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, a=0;
            while (true)
            {
                try
                {
                    Console.Write("Введите а=");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода!");
                    continue;
                }
                break;
            }
            z1 = 5 - 2 * Math.Pow(a,2);
            z1 /= (1 + a + Math.Pow(a, 2)) / (2 * a + Math.Pow(a, 2)) + 2 - (1 - a + Math.Pow(a, 2)) / (2 * a - Math.Pow(a, 2));
            Console.WriteLine("z1=" + z1);
            z2 = (4 - Math.Pow(a, 2)) / 2;
            Console.WriteLine("z2=" + z2);
            if (z1 == z2)
                Console.WriteLine("z1=z2");
            Console.WriteLine("Для выхода нажми что-нибудь");
            Console.ReadKey(true);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeorArg_lab5_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            Double MAX = 10, MIN = -5, imul_neg=1, sum_pos=0; //sum_pos сумма всех положительных
            Int32 long_array = 10;
            double[] array = new double[long_array];
            for (int i = 0; i < long_array; i++)
            {
                array[i] = Rand(MAX,MIN);
            }
            Double max_add = MIN;
            for (int i=0; i<long_array;i++)
            {
                Console.WriteLine("Элемент массива "+i+"\tЗначение: "+array[i]);
                if (array[i] < 0) imul_neg = imul_neg * array[i];
                else sum_pos = sum_pos + array[i];
                if (max_add < array[i]) max_add = array[i];
            }
            if (imul_neg == 1) Console.WriteLine("Отрицательных элементов в массиве нет");
            else Console.WriteLine("Произведение отрицательных = ");
            Console.WriteLine("Сумма положительных (без максимального элемента) = " + (sum_pos - max_add));
            Console.ReadKey(true);
        }
        public static Double Rand(Double max, Double min)
        {
            Random rand = new Random();
            return Math.Round(rand.NextDouble() * max - rand.NextDouble() * min, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorAlg_lab6_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            int edge = 0, sum = 0; //edge - ребро квадратной матрицы
            Console.WriteLine("Квадратная матрица");
            Console.Write("Укажите кол-во строк(столбцов): ");
            edge=Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[edge, edge]; //объявление

            #region Заполнение матрицы (двумерного массива)
            Random rand = new Random();
            for (int i = 0; i < edge; i++)
            {
                for (int j = 0; j < edge; j++)
                {
                    matrix[i, j] = rand.Next(-10,100);
                }
            }
            #endregion

            #region Форматированный вывод матрицы
            for (int i = 0; i < edge; i++)
            {
                for (int j = 0; j < edge; j++)
                {
                    Console.Write("______");
                }
                Console.WriteLine();
                for (int j = 0; j < edge; j++)
                {
                    Console.Write("|" + String.Format("{0,5:0.#}", matrix[i, j]));
                }
                Console.WriteLine("|");
                for (int j = 0; j < edge; j++)
                {
                    Console.Write("|_____");
                }
                Console.WriteLine("|");
            }
            #endregion
            Console.WriteLine("\n");
            #region Задание пункт 1
            for (int i = 0, sum_line=0; i < edge; i++)
            {
                for (int j = 0; j < edge; j++)
                {
                    if (matrix[i, j] >= 0) sum_line += matrix[i, j];
                    else { sum_line = 0; break; }
                }
               if(sum_line!=0) Console.WriteLine("Сумма элементов строки "+(i+1)+", не содержаoщей отрицательных элементов: " + sum_line);
                sum += sum_line;
                sum_line = 0;
            }
            Console.WriteLine("Сумма элементов строк, которые не содержат отрицательных элементов: " + sum);
            #endregion

            #region Задание пункт 2
            int[] Sum = new int[2 * (edge - 2)];
            for (int pass = 1; pass <= edge-2; pass++)//j(1..4) pass(1..3)
            {
                int sum_top = 0, sum_bot = 0;
                for (int i = 0, j = pass; j < edge; i++,j++)
                {
                    sum_top += matrix[i,j];
                    sum_bot += matrix[j,i];
                }
                Sum[pass-1] = sum_top;
                Sum[2 * (edge - 2)-pass] = sum_bot;
            }
            Array.Sort(Sum);
            /*for (int item=0; item< 2 * (edge - 2); item++)
            {
                Console.WriteLine("Диагональ с минимальной суммой элементов: " + Sum[item]);
            }*/
            Console.WriteLine("Диагональ с минимальной суммой элементов: " + Sum[0]);
            #endregion

            Console.ReadKey(true);
        }
    }
}

using System;
using System.Threading;

namespace TeorArg_lab5_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            Double imul_neg = 1, sum_pos = 0; //sum_pos сумма всех положительных
            int long_array = 11, MAX = 100, MIN = -100;
            Double[] array = new Double[long_array]; //объявление
            for (int i = 0; i < long_array; i++) //заполнение
            {
                array[i] = Rand(MAX, MIN);
                Thread.Sleep(150);
            }
            Console.WriteLine("     Содержание массива");
            Console.WriteLine("     _________________");
            Console.WriteLine("     |  ID |array[ID]|");
            Console.WriteLine("     |_____|_________|");
            for (int id=0; id< long_array;id++) //вывод 
            {
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", id) + "|" + String.Format("{0,9:0.##}", array[id]) + "|");
                Console.WriteLine("     |_____|_________|");
            } 
            // задание: пункт 1
            for (int i = 0; i < long_array; i++)
            {
                if (array[i] < 0) imul_neg = imul_neg * array[i];
            }
            // задание: пункт 2
            int ID_max_element = 0,slider=1; //slider - переменная "бегунок" проходящая по массиву (хранит интендификатор текущего элемента)
            while (slider<long_array)
            {
                if (array[ID_max_element] < array[slider]) //"бегунок" проходит по массиву и сравнивает текущий ("свой") элемент массива с предполагаемым максимальным
                    ID_max_element = slider; // если условие "бегунка" выполнилось, то текущий элемент "бегунка" занимает место предполагаемого максимального элемента в условии "бегунка"
                slider++;
            }
            for (int i = 0; i < ID_max_element; i++) //суммирование положительных элементов расположенный до максимального
            {
                if (array[i] > 0) sum_pos = sum_pos + array[i]; //на случай того, что все элементы массива будут <=0, при этом sum_pos=0
            }


            Console.WriteLine("\nПроизведение отрицательных элементов: " + imul_neg);
            Console.WriteLine("\nСумма положительных (до максимального элемента):"+sum_pos); 
            // задание: пункт 3
            Double data;
            for (int id = 0; id < long_array/2; id++)//создание обратного массива
            {
                data = array[id];
                array[id] = array[long_array - id - 1];
                array[long_array - id - 1] = data;
            }
            Console.WriteLine("\n\tОбратный массив");
            Console.WriteLine("     _________________");
            Console.WriteLine("     |  ID |array[ID]|");
            Console.WriteLine("     |_____|_________|");
            for (int id = 0; id < long_array; id++) //вывод обротного
            {
                Console.WriteLine("     |" + String.Format("{0,5:0.#}", id) + "|" + String.Format("{0,9:0.##}", array[id]) + "|");
                Console.WriteLine("     |_____|_________|");
            }
            Console.ReadKey(true);
        }
        public static Double Rand(int max, int min) //функция случайных значений
        {
            Random rand = new Random();
            return Math.Round(rand.NextDouble(),2)*rand.Next(min,max);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorAlg_lab2_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y=0,R;
            while (true)
            {
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                if (x < -1)
                    y = -(x + 1);
                else if (-1 <= x && x <= 1)
                    y = 0;
                else if (1 < x && x < 5)
                    y = Math.Sqrt(4 - Math.Pow((x - 3), 2));
                else if (5 <= x)
                    y = -0.5 * x + 2.5;
                Console.WriteLine("y="+ y);
                Console.WriteLine("Приступить ко второму заданию? (Да - да, Нет - любой символ)");
                if (Console.ReadLine()=="да") break;
             }
            while (true)
            {
                Console.Write("Введите R=");
                R = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите у=");
                y = Convert.ToDouble(Console.ReadLine());
                if (((Math.Sqrt((R+x)*(R-x))<=y&&y<=2*R)&&(x>=0&&x<=2*R))||((2*R-x>=y&&y>=0)&&(-2*R<=x&&x<=0)))
                    Console.WriteLine("Пара (х;у) принадлежит области");
                else
                    Console.WriteLine("Пара (х;у) не принадлежит области");
                Console.WriteLine("Вернуться к началу задания? (Да - любой символ, Нет - нет)");
                if (Console.ReadLine() == "нет") break;
            }
        }
    }
}

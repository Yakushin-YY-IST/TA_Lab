using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeorAlg_lab4_var19
{
    class CPU
    {
        private string model_name_CPU; //Название процессора
        private Double cashe_size; //объем КЭШа
        private Double clock_Rate; //Тактовая частота
        private Double price_CPU; //Цена

        public CPU(string Model_name_CPU, string Cashe_size, string Clock_Rate, string Price_CPU)
        {
            try
            {
                model_name_CPU = Model_name_CPU;
                if (Convert.ToDouble(Cashe_size) > 0) cashe_size = Convert.ToDouble(Cashe_size); else Console.WriteLine("Значение КЭШ памяти должно быть больше нуля");
                if (Convert.ToDouble(Clock_Rate) > 0) clock_Rate = Convert.ToDouble(Clock_Rate); else Console.WriteLine("Значение частоты процессора должно быть больше нуля");
                if (Convert.ToDouble(Price_CPU) >= 0) price_CPU = Convert.ToDouble(Price_CPU); else Console.WriteLine("Значение стоимости должно быть положительным");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }
        } //конец конструктора

        public CPU(CPU other)
        {
            model_name_CPU = other.model_name_CPU;
            clock_Rate = other.clock_Rate;
            cashe_size = other.cashe_size;
            price_CPU = other.price_CPU;
        }

        public void info_CPU()
        {
            Console.WriteLine("Информация о процессоре:\n\tНазвание модели: " + model_name_CPU + "\n\tТактовая частота: " + clock_Rate + " ГГц" + "\n\tОбъем КЭШ памяти: " + cashe_size + " МБ" + "\n\tСтоимость: " + price_CPU + " Руб.");
        }
    }

    class MotherBoard
    {
        private string Model;
        private Double RAM;
        private Double Price;
        public MotherBoard(CPU cpu, String model, String ram, String price)
        {
            cpu = new CPU(cpu);
            try
            {
                Model = model;
                if (Convert.ToDouble(ram) > 0) RAM = Convert.ToDouble(ram); else Console.WriteLine("Значение оперативной памяти должно быть больше нуля");
                if (Convert.ToDouble(price) >= 0) Price = Convert.ToDouble(price); else Console.WriteLine("Значение стоимости должно быть положительным");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }
        } //конец конструктора

        public void info_MB()
        {
            Console.WriteLine("Информация о материнской плате:\n\tНазвание модели: " + Model + "\n\tОбъем КЭШ памяти: " + RAM + " МБ" + "\n\tСтоимость: " + Price + " Руб.");
        }
        class Program
        {
            static void Main(string[] args)
            {
                CPU MidNight_1 = new CPU("MidNight_1", "8", "3", "2400");
                MotherBoard TotalАgony = new MotherBoard(MidNight_1, "Total Agony", "8000", "1100");
                TotalАgony.info_MB();
                MidNight_1.info_CPU();
                Console.ReadKey();
            }
        }
    }
}


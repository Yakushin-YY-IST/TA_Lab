using System;
using System.IO;

namespace TeorAlg_lab7_var19
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText("lab.omg");
            string text = reader.ReadToEnd();
            Console.WriteLine("\nИсходный текст: \n");
            Console.WriteLine(text);
            Console.WriteLine("\n\nПреобразованный текст: \n");
            text = text.Replace(".", ".//|replace|\\");
            text = text.Replace("?", "?//|replace|\\");
            text = text.Replace("!", "!//|replace|\\");

            string[] sentence = text.Split(new string[] { "//|replace|\\ ", "//|replace|\\" }, StringSplitOptions.RemoveEmptyEntries);
            int step = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                string[] offcut = sentence[i].Split(new string[] { "\r","\n"},  StringSplitOptions.RemoveEmptyEntries);

                if (offcut[0].IndexOf(" ") == 1)
                {
                    string temp = sentence[step];
                    sentence[step] = sentence[i];
                    sentence[i] = temp; step++;
                }
            }
            for (int item = 0; item < sentence.Length; item++)
            {
                if (item <= step) { Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black; }
                else { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Gray; }
                Console.WriteLine(sentence[item]);
            }
            Console.ReadKey();
        }
    }
} //с оптимизацией под числа string[] offcut = sentence[i].Split(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",".",")","\r","\n" },  StringSplitOptions.RemoveEmptyEntries);

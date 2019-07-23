using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення числа
            Console.WriteLine("Введіть число:\n");
            Console.Write("\ta = ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));

            // аналіз і розрахунок числа
            _ = (a > 3) ? (a += 10) : (a *= 10);
            // Примітка. Можливо буде путатина із визначенням "умножить это число в 10 раз"
            // Можливо малось на увазі саме на себе помножити 10 разів то треба було б використати a *= Math.Pow(a, 10)
            // не беремо до уваги базове значення, а маємо ще 10 разів помножити саме на себе
            // необхідно уточнити завдання

            // виведення
            Console.WriteLine($"\n\tРезультат: {a:N}");

            // Delay
            Console.ReadKey();
        }
    }
}

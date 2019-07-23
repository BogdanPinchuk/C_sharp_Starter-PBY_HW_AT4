using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення сторін прямокутника
            Console.WriteLine("Введіть сторони прямокутника:\n");
            Console.Write("\ta = ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tb = ");
            double b = double.Parse(Console.ReadLine().Replace(".", ","));

            // Виведення сповіщення, що це може бути квадратом
            if ((a == b) && (a > 0) && (b > 0))
            {
                Console.WriteLine("\nБудьте уважні, Ви задали параметри квадрата!");
            }
            else if ((a <= 0) || (b <= 0))
            {
                Console.WriteLine("\nСторони фігури не можуть бути менші або рівні нулю!");
            }

            // Індентифікатор клавіші
            ConsoleKeyInfo button;

            // Вибір розрахунку
            if ((a > 0) && (b > 0))
            {
                Console.WriteLine("\nВиберіть, що розрахувати:\n" +
                    "площу чи периметр [s, p]");
                Console.Write("\t");
                button = Console.ReadKey();

                switch (button.KeyChar.ToString().ToLower())
                {
                    case "s":
                    case "і":
                    case "ы":
                        Console.WriteLine($"\n\n\tПлоща фігури: S = {a * b};\n");
                        break;
                    case "p":
                    case "з":
                        Console.WriteLine($"\n\n\tПериметр фігури: P = {2 * (a + b)};\n");
                        break;
                    default:
                        Console.WriteLine($"\n\n\tВи ввели невірний символ!;\n");
                        break;
                }
            }

            // Повторення
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            button = Console.ReadKey();

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
        }
    }
}

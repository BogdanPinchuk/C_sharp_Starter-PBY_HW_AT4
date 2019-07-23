using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp5
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть числа:\n");
            Console.Write("\tx = ");
            double x = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\ty = ");
            double y = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tz = ");
            double z = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\ta = ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tb = ");
            double b = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\td = ");
            double d = double.Parse(Console.ReadLine().Replace(".", ","));

            // Незрозуміло що означає [y]? https://uk.wikipedia.org/wiki/Дробова_частина_числа
            // 1. ціла частина числа [y] = y - {y} = y - (y % 1) - ймовірніший варіант
            // 2. варіант це модуль |у|

            // Перевірка на невизначеність 0/0
            if ((x == 0) || (z == y - (y % 1)) &&
                ((y == 0) || (d == 0) ||
                (a == b * b)))
            {
                Console.WriteLine("\nМаємо невизначеність m = NaN, тобто ділення 0/0.");
            }
            else if ((x == 0) || (z == y - (y % 1))) // перевірка ділення на 0
            {
                Console.WriteLine($"\nВ реальності матимемо: m = ±∞ в залежнсоті від інших змінних,\n" +
                    $"але ні шкільна навчальна програма ні програма не можуть ділити на нуль.");
            }
            else if (a < b * b)  // Перевірка на комплексність
            {
                Console.WriteLine($"\nВ реальності матимемо, що m - комплексне число,\n" +
                    $"але в шкільній навчальна програмі парктично не вивчають цього\n" +
                    $"а програма потребує використання додаткової бібліотеки System.Numeric");
            }
            else
            {
                double m = (y * d * Math.Sqrt(a - b * b)) / 
                    (x * (z - (y - (y % 1))));
                Console.WriteLine($"\nРезультат розрахунку: m = {m:N};");
            }

            // Повторення
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey();

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp3
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть 3 числа:\n");
            Console.Write("\ta = ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tb = ");
            double b = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tс = ");
            double c = double.Parse(Console.ReadLine().Replace(".", ","));

            // аналіз введених чисел
            Console.WriteLine();
            if ((a < b) && (a < c))
            {
                Console.WriteLine($"Найбільша сума: S = {b + c:N} при числах b і с\n");
            }
            else if ((b < a) && (b < c))
            {
                Console.WriteLine($"Найбільша сума: S = {a + c:N} при числах a і с\n");
            }
            else if ((c < a) && (c < b))
            {
                Console.WriteLine($"Найбільша сума: S = {a + b:N} при числах a і b;\n");
            }
            else
            {
                Console.WriteLine($"Всі числа рівні, а сума 2-х: S = {a + b:N};\n");
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

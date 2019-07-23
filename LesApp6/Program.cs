using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp6
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть 4 цілі числа:\n");
            Console.Write("\ta = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tb = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\tc = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("\td = ");
            int d = int.Parse(Console.ReadLine());

            // це все  можна реалізвати за допомогою колекцій, списків і масивів
            // але на даний момент необхідно дотриматися умов що цього не відомо

            // Перевірка на парність
            bool ab = a % 2 == 0,
                bb = b % 2 == 0,
                cb = c % 2 == 0,
                db = d % 2 == 0;

            int maxNum = default;

            // перевірка чи взагалі є парне число
            if (ab || bb || cb || db)
            {
                // Базове присвоєння для подальшого перебору
                // просто умовно приймаємо, що перше введене число парне
                maxNum = a;

                // Пошук серед інших чисел
                if (bb)
                {
                    maxNum = Math.Max(b, maxNum);
                }

                if (cb)
                {
                    maxNum = Math.Max(c, maxNum);
                }

                if (db)
                {
                    maxNum = Math.Max(d, maxNum);
                }

                // Примітка. Не було вказано назвати його чи його порядок введення
                Console.WriteLine($"\nНайбільше парне число: {maxNum:N0}");
            }
            else
            {
                Console.WriteLine("\nПарні числа відсутні.\nNot found.");
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

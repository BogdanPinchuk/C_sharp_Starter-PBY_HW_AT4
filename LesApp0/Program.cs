using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення чисел
            Console.WriteLine("Введіть цілі числа:\n");
            Console.Write("\ta = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tb = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\tc = ");
            int c = int.Parse(Console.ReadLine());

            // індентифікатор для результату, що виводитиметься
            double res = default;

            // сума чисел
            int sum = a + b + c;

#if false
            // через оператор if-else
            if (sum % 2 == 0)   // якщо сума парна
            {
                res = Math.Pow(a, b);
            }
            else  // якщо сума непарна
            {
                res = a * b * c;
            }
#endif

#if false
            // через оператор switch-case
            switch (sum % 2 == 0)
            {
                case true:  // якщо сума парна
                    res = Math.Pow(a, b);
                    break;
                case false:  // якщо сума непарна
                    res = a * b * c;
                    break;
            }
#endif

#if true
            // через тернарний оператор
            res = (sum % 2 == 0) ? Math.Pow(a, b) : (a * b * c);
#endif

            // Виведення результату
            Console.WriteLine($"\n\tРезультат: {res:N};");

            // Delay
            Console.ReadKey();
        }
    }
}

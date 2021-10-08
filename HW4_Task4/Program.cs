using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Числа Фибоначчи — элементы числовой последовательности в которой первые
два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел.");
            Console.Write("\n\n\nВведите порядковый номер искомого числа Фибоначчи: ");
            int numb = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{numb}-e число Фибоначчи равно {fibNumbers(numb)}\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static int fibNumbers(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;

            }
            else
            {
                return fibNumbers(n - 1) + fibNumbers(n - 2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWinter = false;
            string[] Winter = new[] {"January", "February", "December"};
            Console.WriteLine("Укажите месяц:");
            string Month = Console.ReadLine();
            for (int i = 0; i < Winter.Length; i++)
            {
                if (Month == Winter[i])
                {
                    isWinter = true;
                    break;
                }

            }

            if (isWinter)
            {
                Console.WriteLine("Введите среднюю температуру: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                if (temperature > 0)
                {
                    Console.WriteLine("Дождливая зима");
                }
                
            }
            Console.WriteLine("Выход из программы");
            Console.ReadKey();

        }
    }
}

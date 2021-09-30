using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double min_temp, max_temp, average_temp;
            Console.WriteLine("Введите минимальную суточную температуру: ");
            min_temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную суточную температуру: ");
            max_temp = Convert.ToDouble(Console.ReadLine());
            average_temp = (max_temp + min_temp) / 2;
            Console.WriteLine(average_temp);

        }
    }
}

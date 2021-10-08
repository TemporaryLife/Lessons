using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите набор чисел через пробел: ");
            string input=Console.ReadLine();
            string[] arr = input.Split(' ');
            Console.WriteLine($"Сумма введенных чисел: {sum(arr)}");

        }

        static int sum(string[] input)
        {
            int summa=0;
            for (int i = 0; i < input.Length; i++)
            {
                summa += Convert.ToInt32(Convert.ToString(input[i]));
            }

            return summa;
        }
        
    }
}

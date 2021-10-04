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
            string input=Console.ReadLine();
            int res=sum(input);
            Console.WriteLine(res);
        }

        static int sum(string input)
        {
            int number,summa=0;
            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(Convert.ToString(input[i]), out number);
                summa += number;
            }

            return summa;
        }
        
    }
}

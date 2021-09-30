using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Офис работает в ");
            byte  Office_1=0b_0000111; //работает Пн-Пт

            if ((Office_1 & 0b_1000000)==0b_1000000)
            {
                Console.Write("Пн ");
            }
            if ((Office_1 & 0b_0100000) == 0b0100000)
            {
                Console.Write("Вт ");
            }
            if ((Office_1 & 0b_0010000) == 0b0010000)
            {
                Console.Write("Ср ");
            }
            if ((Office_1 & 0b_0001000) == 0b0001000)
            {
                Console.Write("Чт ");
            }
            if ((Office_1 & 0b_0000100) == 0b0000100)
            {
                Console.Write("Пт ");
            }
            if ((Office_1 & 0b_0000010) == 0b0000010)
            {
                Console.Write("Сб ");
            }
            if ((Office_1 & 0b_0000001) == 0b0000001)
            {
                Console.Write("Вс ");
            }

            Console.ReadKey();
        }
    }
}

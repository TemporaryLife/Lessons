using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase=Console.ReadLine();
            for(int i=phrase.Length-1;i>=0; i--)
            {
                Console.Write(phrase[i]);
            }
            Console.ReadKey();
        }
    }
}

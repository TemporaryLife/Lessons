using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var massiv=new string[5,2];
            for (int i=0; i<=massiv.GetUpperBound(0); i++)
            {
                for (int j=0; j<=massiv.GetUpperBound(1);j++)
                {
                    if (j%2==0)
                    {
                        Console.Write("Введите имя контакта: ");
                        massiv[i,j]=Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Введите телефон или email: ");
                        massiv[i,j]=Console.ReadLine();
                    }
                    
                }
            }

            
            Console.ReadKey();
        }
    }
}

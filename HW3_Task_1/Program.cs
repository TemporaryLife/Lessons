using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HW3_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entry;
            string spaces="";
            Console.Write("Введите количество строк в массиве: ");
            int i=int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int j=int.Parse(Console.ReadLine());
            var massiv=new int[i,j];
            try
            {
                Console.WriteLine("Заполнение массива по строкам:");
                for (int k=0; k<i; k++)
            {
                entry=(Console.ReadLine()).Split(' ');
                for (int f = 0; f < j; f++)
                    {
                    massiv[k,f]=Convert.ToInt32(entry[f]);
                    
                    }


            }
            Console.WriteLine("Вывод матрицы по диагонали:");
            for (int k=0; k<i; k++)
            {
                
                for (int f = 0; f < j; f++)
                    {
                    Console.WriteLine($"{spaces+massiv[k,f]}");
                    spaces+=" ";
                    }
            }
            
            Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Выход из программы.");
                Thread.Sleep(2000);
            }
            

        }
    }
}

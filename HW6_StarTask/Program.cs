using System;
using System.Collections.Generic;

namespace HW6_StarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размерность массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                var a = InputArray(size);
                var b = SortAndMax(a);
                var res = FindLostNumber(b, a);
                Console.WriteLine($"Минимальное пропущенное число в последовательности: {res}");
                Console.ReadLine();
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {
                Console.WriteLine("Непредвиденная ошибка. Выход из программы.");
            }
            

        }

        static List<int> InputArray(int n)
        {

            List<int> res=new List<int>();
            Console.WriteLine("Введите числа для массива. После введения каждого из чисел нажмите Enter." );

            for (int i = 0; i < n; i++)
            {
                res.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();
            
            return res;

        }

        static int SortAndMax(List<int> array)
        {

            array.Sort();
            int max = array[array.Count - 1];

            if (max <= 0) return 1;

            else return max;
            
        }

        static int FindLostNumber(int max, List<int> arr)
        {
            int lost=1;
            bool flag = false;
            for (int i = max; i >= 1; i--)
            {
                if (!arr.Contains(i))
                {
                    lost = i;
                    flag = true;
                }
            }

            return !flag ? max + 1 : lost;
            
        }
    }
}

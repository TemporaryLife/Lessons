using System;

namespace ttt
{
    class Program
    {
        public static int[] array_1 = new[] {5, 6, 10};
        public static int[] array_2 = new[] {1, 4};
        static void Main(string[] args)
        {
            double a=Median();
            Console.WriteLine($"Медиана двух заданных списков равна {a}");
        }

        static int[] JoinArray(int[] arr1, int[] arr2)
        {
            var result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result,0);
            arr2.CopyTo(result, arr1.Length);
            Array.Sort(result);
            return result;
        }

        static double Median()
        {
            var res=JoinArray(array_1, array_2);
            if (res.Length % 2 == 0)
            {
                return ((double)res[res.Length / 2] + res[res.Length / 2 -1]) / 2;
            }
            else
            {
                return res[res.Length / 2];
            }
        }
    }
}

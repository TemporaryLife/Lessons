using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Анатолий", "Яценко", "Александрович"));
            Console.WriteLine(GetFullName("Иван", "Иванов", "Иванович"));
            Console.WriteLine(GetFullName("Кирилл", "Сарычев", "Игоревич"));
            Console.WriteLine(GetFullName("Егор", "Иванов", "Андреевич"));
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}

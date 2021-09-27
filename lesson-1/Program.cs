using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Привет, {username}, сегодня {DateTime.Now.ToLongDateString()}");
        }
    }
}

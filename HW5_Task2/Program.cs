using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Konstantin\source\repos\TemporaryLife\Lessons\HW5_Task2\startup.txt";
            string text;
            Console.Write("Хотите ли вы внести изменения в файл?(Да/Нет) ");
            string ans=Console.ReadLine();

            if (ans == "Да")
            {
                Console.WriteLine(@"Перезаписать в файл? Если дан ответ 'Нет', то изменения просто добавятся в конец файла ");
                ans = Console.ReadLine();
                if (ans == "Да")
                {
                    text = Console.ReadLine();
                    File.WriteAllText(path, $"{text}   ({DateTime.Now})\n");
                }
                else if (ans == "Нет")
                {
                    text = Console.ReadLine();
                    File.AppendAllText(path, $"{text}   ({DateTime.Now})\n");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }

            }
            else if (ans == "Нет")
            {
                return;
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine($"Дата последнего доступа к файлу: {DateTime.Now}");
                return;
            }


        }
    }
}

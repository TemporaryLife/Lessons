using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Task4
{
    class Program
    {
        public static string path_tofunc = @"D:\Documents\Desktop\Яценко А.А";
        public static string file_path = @"D:\Documents\Desktop\Яценко А.А\HW5Task4.txt";
        static void Main(string[] args)
        {
            File.Delete(file_path);
            Console.WriteLine("Использовать рекурсию? (Исследовать дерево вглубь?) (Да/Нет)");
            string ans = Console.ReadLine();
            if (ans == "Да")
            {
                Dire_Recursion(path_tofunc, file_path);
            }
            else
            {
                Dire(path_tofunc, file_path);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат записан в указанный файл.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void Dire_Recursion(string path, string writingfile_path )
        {

            foreach (string d in Directory.GetDirectories(path))
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                File.AppendAllText(writingfile_path, $"Директория {d}\nФайлы:\n\n");

                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (string f in Directory.GetFiles(d)) 
                {
                    File.AppendAllText(writingfile_path, $"{f}\n");
                    
                }


                Dire_Recursion(d, writingfile_path);

                
            }
        }

        static void Dire(string path, string writingfile_path )
        {
            File.AppendAllText(writingfile_path, "Директории\n");

            foreach (string d in Directory.GetDirectories(path))
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                File.AppendAllText(writingfile_path, $"{d}\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                

            }
            File.AppendAllText(writingfile_path, "\n\nФайлы\n");

            foreach (string f in Directory.GetFiles(path)) 
            {
                File.AppendAllText(writingfile_path, $"{f}\n");
                    
            }
        }


        
    }
}

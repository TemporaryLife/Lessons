using System;
using System.CodeDom;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileText = Console.ReadLine();
            string path =@"C:\Users\Konstantin\source\repos\TemporaryLife\Lessons\HW5\Task1.txt" ;
            FileCW(FileText, path ); 
        }


        static void FileCW(string text, string path)
        {
            File.WriteAllText(path, text);
        }
    }
}

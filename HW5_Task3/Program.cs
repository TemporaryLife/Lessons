using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bytes_Array = new List<byte>();
            Bytes_Array=CreateBytesArray();
            WriteInFile(Bytes_Array);

        }

        static List<byte> CreateBytesArray()
        {
            Console.WriteLine("Введите числа для записи в файл (от 0 до 255): ");
            var res=new List<byte>();
            byte number;
            string input = Console.ReadLine();
            string[] str_numbers = input.Split(' ');
            foreach (string symb in str_numbers)
            {
                byte.TryParse(symb, out number);
                res.Add(number);
            }

            return res;
        }

        static void WriteInFile(List<byte> input)
        {
            byte[] array = input.ToArray();
            File.WriteAllBytes(@"C:\Users\Konstantin\source\repos\TemporaryLife\Lessons\HW5_Task3\bytes.bin", array);
        }
    }
}

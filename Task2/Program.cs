using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte month_number = Convert.ToByte(Console.ReadLine());
            string month_name="";
            switch (month_number)
            {
                case 1: month_name = "January"; break;
                case 2: month_name = "February"; break;
                case 3: month_name = "March"; break;
                case 4: month_name = "April"; break;
                case 5: month_name = "May"; break;
                case 6: month_name = "June"; break;
                case 7: month_name = "July"; break;
                case 8: month_name = "August"; break;
                case 9: month_name = "September"; break;
                case 10: month_name = "October"; break;
                case 11: month_name = "November"; break;
                case 12: month_name = "December"; break;

            }
            Console.WriteLine(month_name);
            Console.ReadKey();
        }
    }
}

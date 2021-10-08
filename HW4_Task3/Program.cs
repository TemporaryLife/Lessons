using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task3
{
    class Program
    {
        enum Year_Times
        {
            Winter=1,
            Spring=2,
            Summer=3,
            Autumn=4
        }

        public static int Convertation(int month)
        {
            try
            {
                switch (month)
                {
                    case 1:
                    case 2:
                    case 12:
                        return (int) Year_Times.Winter;
                    case 3:
                    case 4:
                    case 5:
                        return (int) Year_Times.Spring;
                    case 6:
                    case 7:
                    case 8:
                        return (int) Year_Times.Summer;
                    case 9:
                    case 10:
                    case 11:
                        return (int) Year_Times.Autumn;
                    default: throw new ArgumentException();
                    

                }
            }
            catch (ArgumentException)

            {
                return 0;
            }
            catch (Exception)
            {

                return 0;
            }
           
        }
        static string ToMonth(int Year_Time)
        {
            switch (Year_Time)
            {

                case 1:
                    return "Зима";
                case 2:
                    return "Весна";
                case 3:
                    return "Лето";
                case 4:
                    return "Осень";
                default: return "Ошибка. Введите число от 1 до 12";
            }
           
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int a = Convertation(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Время года для заданного месяца - {ToMonth(a)}");
            Console.ReadKey();
        }
    }
}

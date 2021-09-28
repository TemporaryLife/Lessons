using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace Task4
{
    class Program
    {
        static void Main(string[] args)

        {
            
            string seller_name = "Иванов Иван Иванович", location="г.Томск, ул.Усова, д.3А";
            int price_1=100, price_2=200, price_3=75, price_4=100, price_5=250;
            int sum = price_1 + price_2 + price_3 + price_4 + price_5;
            Console.WriteLine($"####################################");
            Console.WriteLine($"#           Кассовый чек           #");
            Console.WriteLine($"#           ООО Ромашка            #");
            Console.WriteLine($"#     {location}      #");
            Console.WriteLine($"#       {DateTime.Now}        #");
            Console.WriteLine($"#   Кассир {seller_name}    #");
            Console.WriteLine($"#  ******************************  #");
            Console.WriteLine($"#                                  #");
            Console.WriteLine($"#   Товар      Цена    Кол-во      #");
            Console.WriteLine($"#  Игрушка      {price_1}      1         #");
            Console.WriteLine($"#  Стул         {price_2}      1         #");
            Console.WriteLine($"#  Стол         {price_3}       1         #");
            Console.WriteLine($"#  Салфетки     {price_4}      1         #");
            Console.WriteLine($"#  Курица       {price_5}      1         #");
            Console.WriteLine($"#  ******************************  #");
            Console.WriteLine($"#                                  #");
            Console.WriteLine($"#         Фиск.Чек №12345          #");
            Console.WriteLine($"#          Код ККТ 12345           #");
            Console.WriteLine($"#            ФН 12345              #");
            Console.WriteLine($"#          ОФД Первый ОФД          #");
            Console.WriteLine($"#                                  #");
            Console.WriteLine($"#                                  #");
            Console.WriteLine($"#                 Итого: {sum} руб.  #");
            Console.WriteLine($"#                                  #");
            Console.WriteLine($"####################################");
            Console.ReadKey();
        }
    }
}

using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HW5_Task5
{
    class Program
    {
        static void Main(string[] args)

        {

            string task_name, json;
            var indexes = new List<int>();
            string path = @"C:\Users\Konstantin\source\repos\TemporaryLife\Lessons\HW5_Task5\bin\Debug\find.json",json_1 = File.ReadAllText(path);;
            bool status = false;
            List<ToDo> json_array = JsonConvert.DeserializeObject<List<ToDo>>(json_1);

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[\n]");
            }
            
            while (true)

            {
                
                ToDo.ShowMessage(json_array, path);
                Console.WriteLine("In/Tag/Del");
                string ans=Console.ReadLine();

                if (ans == "In")

                {
                    Console.Write("Введите название задачи: ");
                    task_name = Console.ReadLine();
                    ToDo Task=new ToDo(task_name, status);
                    json_array.Add(Task);
                    Console.Clear();
                }

                else if(ans=="Tag")

                {
                    Console.WriteLine("Какую задачу считать выполненной? ");
                    int numb=Convert.ToInt32(Console.ReadLine());
                    json_array[numb-1].IsDone = true;
                    indexes.Add(numb - 1);
                }

                else if (ans=="Del")
                {
                    Console.WriteLine("Какую задачу вы хотите удалить? ");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    json_array.RemoveAt(numb-1);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }


                string str = JsonConvert.SerializeObject(json_array);
                File.WriteAllText(path, str);

        }
            
            

         
        }
        
    }
}

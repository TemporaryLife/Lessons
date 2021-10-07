using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo Task1=new ToDo("Почистить печь", false);
            Task1.IsDone = true;
            Task1.Title = "123";
            string json = JsonSerializer.Serialize(Task1);
            File.WriteAllText("new.json",json );
        }
        
    }
}

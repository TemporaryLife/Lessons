using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace HW5_Task5
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; } 
        public ToDo(string Title, bool IsDone)
        {
            this.Title = Title;
            this.IsDone = IsDone;
        }
        public static void ShowMessage(List<ToDo> json_array, string path)
        {
            
            if (File.Exists(path))
            {

                List<int> indexes=new List<int>();
                
                for (int i = 1; i <= json_array.Count; i++)
                {
                    indexes.Add(i);
                }
                Console.Clear();
                for (int j=0; j<json_array.Count;j++)
                {
                    if (json_array[j].IsDone)
                    {
                        Console.WriteLine($"{indexes[j]}. [x]{json_array[j].Title}");
                    }
                    else
                    {
                        Console.WriteLine($"{indexes[j]}. {json_array[j].Title}");
                    }
                    
                }
                }

        }

        

        public ToDo()
        {

        }
    }
}

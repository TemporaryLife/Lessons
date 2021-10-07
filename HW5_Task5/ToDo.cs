using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



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
    }
}

using System;
using System.Diagnostics;
using System.Threading;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)

            {

                var Processes=Process.GetProcesses();

                for (int i = 0; i < Processes.Length; i++)

                {

                    Console.WriteLine($"ID: {Processes[i].Id} || Name: {Processes[i].ProcessName}");

                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\nВведите ID или имя процесса. В случае нахождения нескольких процессов с одинаковым именем, будут завершены все экземпляры. ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string ans = Console.ReadLine();

                bool parsedAns = int.TryParse(ans, out int n), isHere=false;

                foreach (Process Proc in Processes)

                {

                    if (ans==Proc.ProcessName || (n == Proc.Id && n!=0))

                    {
                        Console.Clear();

                        Console.WriteLine("Процесс найден. Удаление...");

                        Thread.Sleep(1000);

                        isHere = true;

                        Proc.Kill();

                    }

                    
                }

                if (!isHere)

                {

                    Console.Clear();

                    Console.WriteLine("Такого процесса нет, повторите попытку.");

                    Thread.Sleep(1000);

                }

                
                Console.Clear();

            }
            

        }
    }
}

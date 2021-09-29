using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Warships=new [,]{ {"X","O","O","X","X","X","X","O","X","X"},
                                  {"O","O","O","O","O","O","O","O","O","O"},
                                  {"X","O","O","O","O","O","O","O","O","X"},
                                  {"X","O","O","O","X","O","O","O","O","O"},
                                  {"O","O","O","O","X","O","O","O","X","O"},
                                  {"O","O","O","O","X","O","O","O","O","O"},
                                  {"O","X","O","O","O","O","O","O","O","O"},
                                  {"O","O","O","O","O","O","X","X","O","O"},
                                  {"O","O","O","O","O","O","O","O","O","O"},
                                  {"X","X","X","O","O","O","O","O","O","O"},};
            for (int i = 0; i<=Warships.GetUpperBound(0); i++)
			{
                for (int j=0; j<=Warships.GetUpperBound(1);j++)
                {
                    if (Warships[i,j]=="X")
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.Write(Warships[i,j]);
                    }
                    else
                    {
                        Console.ForegroundColor=ConsoleColor.Gray;
                        Console.Write(Warships[i,j]);
                    }
                    
                    
                }
                Console.WriteLine();
			}
            Console.ReadKey();
        }
        
    }
}

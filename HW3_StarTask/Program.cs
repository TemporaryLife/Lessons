using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_StarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence=Console.ReadLine();
            string[] splitted;
            string left_side,right_side, max_palindrom="";
            int middle_index, palindrom_length=0;
            splitted=sentence.Split(' ');
            for(int i=0; i<splitted.Length; i++)
            {
                left_side="";
                right_side="";
                if (splitted[i].Length%2==0)
                {
                    middle_index=splitted[i].Length/2;
                   for (int j=0; j<middle_index;j++)
                    {
                        left_side+=splitted[i][j];
  
                    }
                    for (int k=splitted[i].Length-1;k>=middle_index;k--)
                    {
                        right_side+=splitted[i][k];
                        
                    }
                }
                else
                {
                    middle_index=(splitted[i].Length-1)/2;
                    for (int j=0; j<=middle_index;j++)
                    {
                        left_side+=splitted[i][j];

                    }
                    for (int k=splitted[i].Length-1;k>=middle_index;k--)
                    {
                        right_side+=splitted[i][k];
                        
                    }
                }
                 if (left_side.ToLower()==right_side.ToLower())
                {
                    if (splitted[i].Length>palindrom_length)
                    {
                        palindrom_length=splitted[i].Length;
                        max_palindrom=splitted[i];

                    }
                    
                }
            }
            Console.WriteLine($"Самый длинный палиндром - {max_palindrom}");
            Console.ReadKey();
        }
    }
}

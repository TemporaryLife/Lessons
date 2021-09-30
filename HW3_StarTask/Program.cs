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
            string[] splitted;
            bool isHere = false;
            string left_side,right_side, max_palindrom="";
            int middle_index, palindrom_length=0;

            Console.Write("Введите строку: ");              //Исходная строка
            string sentence=Console.ReadLine();
            splitted=sentence.Split(' ');                   //Разбиение строки по словам
            for(int i=0; i<splitted.Length; i++)            
            {
                left_side="";
                right_side="";
                if (splitted[i].Length%2==0)                //Разбиение каждого слова пополам (четное/нечетное количество букв) 
                {
                    middle_index=splitted[i].Length/2;
                   for (int j=0; j<middle_index;j++)
                    {
                        left_side+=splitted[i][j];
  
                    }
                    
                }
                else
                {
                    middle_index=(splitted[i].Length-1)/2;  //Нахождение индекса середины слова и сборка левой и правой части слова
                    for (int j = 0; j <= middle_index; j++) 
                    {
                        left_side += splitted[i][j];

                    }
                }
                for (int k=splitted[i].Length-1;k>=middle_index;k--)
                {
                    right_side+=splitted[i][k];
                        
                }
                 if (left_side.ToLower()==right_side.ToLower())     //Отбрасывание регистра (для проверки на палиндром не имеет роли)
                {
                    if (splitted[i].Length>palindrom_length)        //нахождение максимального по длине палиндрома
                    {
                        palindrom_length=splitted[i].Length;
                        max_palindrom=splitted[i];
                        isHere = true;

                    }
                    
                    
                }
            }

            if (isHere)
            {
                Console.WriteLine($"Самый длинный палиндром - {max_palindrom}");
            }
            else
            {
                Console.WriteLine("В этой строке нет палиндромов.");
            }
            Console.ReadKey();
        }
    }
}

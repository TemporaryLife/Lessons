using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    enum numbers
    {
        I=1,
        V=5,
        X=10,
        L=50,
        C=100,
        D=500,
        M=1000
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string rnumber = Console.ReadLine();
            int bufer=0, bufer2=0,sum=0;

            for (int i = 0; i < rnumber.Length-1; i++)
            {
                switch (rnumber[i])
                {
                    case 'I': bufer =(int)numbers.I ; break;
                    case 'V': bufer =(int)numbers.V ; break;
                    case 'X': bufer =(int)numbers.X ; break;
                    case 'L': bufer =(int)numbers.L ; break;
                    case 'C': bufer =(int)numbers.C ; break;
                    case 'D': bufer =(int)numbers.D ; break;
                    case 'M': bufer =(int)numbers.M ; break;
                }
                if (rnumber.Length == 1)
                {
                    sum = bufer;
                    Console.WriteLine("Зашел");
                }
                else
                {
                    switch (rnumber[i+1])
                    {
                        case 'I': bufer2 =(int)numbers.I ; break;
                        case 'V': bufer2 =(int)numbers.V ; break;
                        case 'X': bufer2 =(int)numbers.X ; break;
                        case 'L': bufer2 =(int)numbers.L ; break;
                        case 'C': bufer2 =(int)numbers.C ; break;
                        case 'D': bufer2 =(int)numbers.D ; break;
                        case 'M': bufer2 =(int)numbers.M ; break;
                    }

                    if (bufer < bufer2)
                    {
                        sum += (bufer2 - bufer);
                    }
                    else
                    {
                        sum += bufer2 + bufer;
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}

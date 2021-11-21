using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N =  ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int per;
            int per2 = 1;
            for (int a = 0; a < N; a++)
            {
                if (per2 == 0)
                {
                    per2 = 1;
                }
                else
                {
                    per2 = 0;
                }
                per = per2;
                for (int b = 0; b < N; b++)
                {
                    if (per == 0)
                    {
                        per = 1;
                    }
                    else
                    {
                        per = 0;
                    }
                    array[a, b] = per;

                    Console.Write("{0} ", array[a, b]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }



    }
}


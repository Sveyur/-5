using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int a = 0; a < 10; a++)
            {
                array[a] = random.Next(-50, 50);
                Console.Write("{0}   ", array[a]);
            }
            for (int a = 0; a < 4; a++)
            {
                for (int k = a + 1; k < 5; k++)
                {
                    if (array[a] > array[k])
                    {
                        int b = array[a];
                        array[a] = array[k];
                        array[k] = b;
                    }
                }
            }
            Console.WriteLine();
            for (int a = 5; a < 9; a++)
            {
                for (int k = a + 1; k < 10; k++)
                {
                    if (array[a] < array[k])
                    {
                        int b = array[a];
                        array[a] = array[k];
                        array[k] = b;
                    }
                }
            }
            for (int a = 0; a < 5; a++)
            {
                Console.Write("{0}  ", array[a]);
            }
            Console.WriteLine();
            for (int a = 5; a < 10; a++)
            {
                Console.Write("{0}  ", array[a]);
            }
            Console.ReadKey();
        }
    }
}

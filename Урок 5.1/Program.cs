using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int a = 0; a < 15; a++)
            {
                array[a] = random.Next(0, 50);
                Console.Write("{0}   ", array[a]);
            }
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число = {0}, минимальное число = {1}", max, min);
            Console.WriteLine("Сумма максимального и минимального числа равна = {0}", max + min);
            Console.ReadKey();
        }
    }
}

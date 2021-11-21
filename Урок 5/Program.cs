using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Console.WriteLine("Введите массив из семи чисел   ");
            int S = 0;          
            for (int a = 0; a < 7; a++)
            {
                array[a] = Convert.ToInt32(Console.ReadLine());
                S += array[a];
            }
            Console.WriteLine("Сумма чисел массива = {0}", S);
            Console.WriteLine("Среднеарифмитическое число массива = {0}", S/7);
            Console.ReadKey();
        }
    }
}

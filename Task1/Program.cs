using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[10];
            array1 = FillArray(array1);
            var array2 = new int[10];
            array2 = FillArray(array2);

            FindAveragePositive(array1);
            OutputArray(array1);

            FindAveragePositive(array2);
            OutputArray(array2);
            Console.ReadLine();
        }

        private static void FindAveragePositive(int[] array)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            Console.WriteLine($"Ср. Ар. Полож. чисел = {sum / count}");
        }

        private static int[] FillArray(int[] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = int.Parse(Console.ReadLine());
                array[i] = rnd.Next(10, 50);
            }
            return array;
        }
        private static void OutputArray(int[] massive)
        {
            foreach (var item in massive)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}

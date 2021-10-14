using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            int lenght1 = rnd.Next(5, 12);
            int lenght2 = rnd.Next(5, 12);

            Console.WriteLine("Введите диапазон случайных чисел(min/max)");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var array1 = new int[lenght1];
            array1 = FillArray(array1, a, b);
            var array2 = new int[lenght2];
            array2 = FillArray(array2, a, b);

            var count1 = FindCountSingleNumber(array1);
            var count2 = FindCountSingleNumber(array2);

            if (count1 > count2)
            {
                Console.WriteLine($"1 Массив| однозначных элементов - {count1}:");
                OutputArray(array1);
                Console.WriteLine($"2 Массив| однозначных элементов - {count2}:");
                OutputArray(array2);
            }
            else if(count1 < count2)
            {
                Console.WriteLine($"2 Массив| однозначных элементов -  {count2}:");
                OutputArray(array2);
                Console.WriteLine($"1 Массив| однозначных элементов -  {count1}:");
                OutputArray(array1);
            }
            else
            {
                Console.WriteLine("Кол-во однозначных элементов одинаково.");
                Console.WriteLine($"1 Массив| однозначных элементов -  {count1}:");
                OutputArray(array1);
                Console.WriteLine($"2 Массив| однозначных элементов -  {count2}:");
                OutputArray(array2);
            }

            Console.ReadLine();
        }

        private static int FindCountSingleNumber(int[] array)
        {
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 10 && array[i] > -10)
                {
                    count++;
                }
            }
            return count;
        }

        private static int[] FillArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
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
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}

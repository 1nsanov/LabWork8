using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            int lenght1 = rnd.Next(5, 12);
            int lenght2 = rnd.Next(5, 12);
            int lenght3 = rnd.Next(5, 12);

            Console.WriteLine("Введите диапазон случайных чисел(min/max)");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите величину с");
            var c = int.Parse(Console.ReadLine());

            var array1 = new int[lenght1];
            array1 = FillArray(array1, a, b);
            var array2 = new int[lenght2];
            array2 = FillArray(array2, a, b);
            var array3 = new int[lenght3];
            array3 = FillArray(array3, a, b);

            OutputArray(array1);
            OutputArray(array2);
            OutputArray(array3);

            if (FindC(array1) > c)
            {
                Console.WriteLine($"Модуль разности наибольшего и наименьшего элемента 1 массива {FindC(array1)} больше величины {c}");
            }
            if (FindC(array2) > c)
            {
                Console.WriteLine($"Модуль разности наибольшего и наименьшего элемента 2 массива {FindC(array2)} больше величины {c}");
            }
            if (FindC(array3) > c)
            {
                Console.WriteLine($"Модуль разности наибольшего и наименьшего элемента 3 массива {FindC(array3)} больше величины {c}");
            }

            Console.ReadLine();
        }

        private static int FindC(int[] array)
        {
            var min = array.Min(m => Math.Abs(m));
            var max = array.Max(m => Math.Abs(m));
            var sumC = max - min;
            //Console.WriteLine($"{min} | {max} | {sumC}");
            return sumC;

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


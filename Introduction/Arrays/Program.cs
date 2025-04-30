//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
            //Console.Write("Введите размер массива: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            int[] arr = new int[] { 3, 5, 8, 13, 21, 34, 55 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Сумма элементов массива: {sum}");
            //Console.WriteLine($"Среднее-арифметическое элементов массива: {(double)sum / arr.Length}");
            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
            Console.WriteLine($"Минимальное занчение в массиве: {arr.Min()}");
            Console.WriteLine($"Максимальное занчение в массиве: {arr.Max()}");

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif

#if ARRAYS_2
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество элементов строки: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];
                //{
                //    { 1, 2, 3 },
                //    { 4, 5, 6 },
                //    { 7, 8, 9 },
                //};
            Console.WriteLine($"Количество измерений массива: {arr.Rank}");
            Console.WriteLine($"Количество строк: {arr.GetLength(0)}");
            Console.WriteLine($"Количество элементов строки: {arr.GetLength(1)}");

            Random rand = new Random(0);    //seed = 0 - начальное значение для генерации случайных чисел.

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().ToArray().Sum()}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Cast<int>().ToArray().Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {arr.Cast<int>().ToArray().Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {arr.Cast<int>().ToArray().Max()}");
#endif

			int[][] arr = new int[][]
				{
					new int[]{ 0, 1, 1, 2 },
					new int[]{ 3, 5, 8, 13, 21 },
					new int[]{ 34, 55, 89 },
					new int[]{ 144, 233, 377, 610 }
				};

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write($"{arr[i][j]}\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			foreach (int[] i in arr)
			{
				foreach (int j in i)
				{
					Console.Write($"{j}\t");
				}
				Console.WriteLine();
			}

			int[] sum_values = new int[arr.Length];
			int[] length_values = new int[arr.Length];
			int min, max;
			min = max = arr[0][0];
			for (int i = 0; i < arr.Length; i++)
			{
				sum_values[i] = arr[i].Sum();
				length_values[i] = arr[i].Length;
				if (arr[i].Min() < min) min = arr[i].Min();
				if (arr[i].Max() > max) max = arr[i].Max();
			}
			Console.WriteLine($"Сумма элементов массива: {sum_values.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {(double)sum_values.Sum() / length_values.Sum()}");

		}
	}
}

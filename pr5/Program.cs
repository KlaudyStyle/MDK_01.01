using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    public class Program
    {

        public static Random random = new Random();

        static void Main(string[] args)
        {
            //практическая 5 зд1 номер 18
            int[] massive = new int[10];
            for(int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(0, 11);
                Console.WriteLine(massive[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                int count = massive.Count(x => x == i);
                Console.WriteLine($"Число {i} встречается {count} раз");
            }

            //практическая 5 зд2 номер 3
            M();
            //практическая 5 зд3 номер 15
            V();
        }

        static void M()
        {
            Console.Write("Введите порядок матрицы n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некорректный ввод. n должно быть целым положительным числом.");
                return;
            }

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int k = Math.Min(i, n - 1 - i);
                for (int j = 0; j <= k; j++)
                {
                    matrix[i, j] = 1;
                }
                for (int j = n - k - 1; j < n; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void V()
        {
            Console.Write("Введите порядок матрицы n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            int[,] matrix = new int[n, n];

            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                    Console.Write("\t "+ matrix[i, j]);
                }
                Console.WriteLine();
            }

            int sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }

            Console.WriteLine("Сумма положительных элементов над главной диагональю " + sum);
            Console.WriteLine("Количество положительных элементов над главной диагональю " + count);
        }
    }
}

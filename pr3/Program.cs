using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    class Program
    {
        static void Main()
        {
            //Практическая 3 задание 3
            Console.WriteLine("Введите число x:");
            double x = double.Parse(Console.ReadLine());

            double result = x;
            result -= Math.Pow(x, 3) / Factorial(3);
            result += Math.Pow(x, 5) / Factorial(5);
            result -= Math.Pow(x, 7) / Factorial(7);
            result += Math.Pow(x, 9) / Factorial(9);
            result -= Math.Pow(x, 11) / Factorial(11);
            result += Math.Pow(x, 13) / Factorial(13);

            Console.WriteLine($"Результат вычисления: {result}");

            //Задание 33
            Console.WriteLine("Введите начальное время в часах (например, 7):");
            int startHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное время в часах (например, 18):");
            int endHour = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВремя\tДлина тени");

            for (int hour = startHour; hour <= endHour; hour++)
            {
                double shadowLength = CalculateShadowLength(hour);
                Console.WriteLine($"{hour}:00\t{shadowLength:F2} м");
            }
        }

        static double CalculateShadowLength(int hour)
        {
            if (hour < 7)
                return 1.5;
            else if (hour > 18)
                return 1.5;
            else
                return 3.0 - 0.1 * (hour - 7);
        }

        static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}

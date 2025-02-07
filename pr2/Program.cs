using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        static void Main()
        {
            //Практическая 2 задание 3
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = F(x);
            Console.WriteLine($"f({x}) = {result}");

            //Текстовые задачи задание 3
            M();

            //Оператор switch задание 2
            Console.WriteLine("Введите число:");
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            int lastDigitSquare = (lastDigit * lastDigit) % 10;

            Console.WriteLine($"Последняя цифра квадрата числа {number} равна {lastDigitSquare}");
        }

        static void M()
        {
            Console.Write("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                int temp = x;
                x = y;
                y = temp;
            }

            Console.WriteLine($"После перераспределения: x = {x}, y = {y}");
        }

        static double F(double x)
        {
            if (x <= 3)
            {
                return Math.Pow(x, 2) + 3 * x + 9;
            }
            else
            {
                return Math.Sin(x) / (Math.Pow(x, 2) - 9);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                //Пр 4 зд 3.1
                double x = Math.PI / 4;
                double result = F(x);
                Console.WriteLine($"F({x}) = {result}");

                //Пр 4 зд 3.2
                double x1 = 1.5;
                double result1 = CalculateLn(x);

                Console.WriteLine($"ln({x1}) = {result1}");
            }
            catch(Exception e) { 
                Console.WriteLine(e.ToString());
            }


        }

        static double CalculateLn(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("x не может быть меньше 0");
            }

            double tolerance = 1e-10;
            double term = (x - 1) / (x + 1);
            double sum = 0.0;
            double powerTerm = term;
            int n = 1;

            while (true)
            {
                double newTerm = powerTerm / (2 * n - 1);
                sum += newTerm;

                if (Math.Abs(newTerm) < tolerance)
                    break;

                n++;
                powerTerm *= term * term;
            }

            return 2 * sum;
        }

        static double F(double x)
        {
            double sinSquared = Math.Pow(Math.Sin(x), 2);
            double cosValue = Math.Cos(x);
            return 7 * sinSquared - (1 / (2 * x)) * cosValue;
        }
    }
}

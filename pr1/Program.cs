namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 (пример 3)
            TestExpression(x: 2, y: 1);
            TestExpression(x: 3, y: 2);
            //задание 2 (пример 3)

            String str = Console.ReadLine();
            GetSymbols(str);
        }

        public static void GetSymbols(String str)
        {
            if (str != null && str.Length == 1)
            {
                int code = str[0];
                Console.WriteLine($"Вы ввели символ {(char)code}, с кодом {code}.");
                Console.WriteLine($"Вывод символа имеющий код на 2 больший {(char)(code + 2)}. (код {(int)code + 2})");
                Console.WriteLine($"Вывод символа последующего {(char)(code + 3)}. (код {(int)code + 3})");
                Console.WriteLine($"Вывод символа предудущего {(char)(code + 1)}. (код {(int)code + 1})");
            }
            else
            {
                Console.WriteLine("Введите один символ!");
            }
        }

        public static void TestExpression(int x, int y)
        {
            try
            {
                if (x == 1)
                {
                    throw new ArgumentException("x не может быть равен 1 (деление на ноль)");
                }

                double part1 = Math.Pow((x + 1) / (x / -1), x);
                double part2 = 18 * x * Math.Pow(y, 2);
                double result = part1 + part2;
                Console.WriteLine($"x = {x}, y = {y}, результат = {result:F2}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
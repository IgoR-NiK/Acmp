using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 323 - "Гипотеза Гольдбаха"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 30%)
    /// 
    /// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
    /// Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.
    ///
    /// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа.
    /// Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N. Первым выводится наименьшее число.
    /// </summary>
    public static class Task0323
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(n, result);
        }

        private static void GetInputData(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        public static int Solve(int n)
        {
            for (var i = 2; i <= n / 2; i++)
            {
                if (IsPrime(i) && IsPrime(n - i))
                {
                    return i;
                }
            }

            return 0;
        }

        private static void PrintResult(int n, int p)
        {
            Console.WriteLine($"{p} {n - p}");
        }

        private static bool IsPrime(int n)
        {
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
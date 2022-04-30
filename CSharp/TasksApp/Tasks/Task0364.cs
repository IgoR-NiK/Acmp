using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 364 - "Совершенные числа"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 51%)
    /// 
    /// Число называется совершенным, если оно равно сумме всех своих делителей, меньших его самого.
    /// Требуется найти все совершенные числа от M до N.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит числа M и N, разделенные пробелом. (1 ≤ M ≤ N ≤ 5*10^18)
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите по одному числу в строке в порядке возрастания все совершенные числа,
    /// находящихся на отрезке [M, N]. В том случае, когда таких чисел нет следует вывести «Absent». 
    /// </summary>
    public class Task0364
    {
        public static void Main()
        {
            GetInputData(out var m, out var n);

            var result = Solve(m, n);

            PrintResult(result);
        }

        private static void GetInputData(out long m, out long n)
        {
            var input = Console.ReadLine().Split();
            
            m = long.Parse(input[0]);
            n = long.Parse(input[1]);
        }

        public static List<long> Solve(long m, long n)
        {
            var result = new List<long>();
            
            for (var p = 2; p < 32; p++)
            {
                if (IsPrime((long)Math.Pow(2, p) - 1))
                {
                    var k = (long)Math.Pow(2, p - 1) * ((long)Math.Pow(2, p) - 1);

                    if (k >= m && k <= n)
                    {
                        result.Add(k);
                    }
                }
            }

            return result;
        }

        private static void PrintResult(List<long> result)
        {
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            if (result.Count == 0)
                Console.WriteLine("Absent");
        }

        private static bool IsPrime(long n)
        {
            for (var i = 2L; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
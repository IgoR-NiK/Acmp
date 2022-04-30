using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 349 - "Простые числа"
    /// (Время: 0,5 сек. Память: 32 Мб Сложность: 28%)
    /// 
    /// Необходимо вывести все простые числа от M до N включительно.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит два натуральных числа M и N, разделенных пробелом (2 ≤ M ≤ N ≤ 10^6)
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите все простые числа от M до N в порядке возрастания, по одному в строке. Если таковых чисел нет, то следует вывести «Absent».
    /// </summary>
    public static class Task0349
    {
        private static readonly List<int> PrimeNumbers = new List<int> { 2 };

        public static void Main()
        {
            GetInputData(out var m, out var n);

            var result = Solve(m, n);

            PrintResult(result);
        }

        private static void GetInputData(out int m, out int n)
        {
            var input = Console.ReadLine().Split();

            m = int.Parse(input[0]);
            n = int.Parse(input[1]);
        }

        public static IEnumerable<int> Solve(int m, int n)
        {
            if (m == 2)
            {
                yield return m;
            }             

            for (var i = 3; i <= n; i += 2)
            {
                if (IsPrime(i) && i >= m)
                {
                    yield return i;
                }                
            }
        }

        private static void PrintResult(IEnumerable<int> result)
        {
            var isEmpty = true;

            foreach (var res in result)
            {
                Console.WriteLine(res);
                isEmpty = false;
            }

            if (isEmpty)
            {
                Console.Write("Absent");
            }
        }

        private static bool IsPrime(int number)
        {
            for (var j = 0; PrimeNumbers[j] * PrimeNumbers[j] <= number; j++)
            {
                if (number % PrimeNumbers[j] == 0)
                {
                    return false;
                }
            }

            PrimeNumbers.Add(number);
            return true;
        }
    }
}
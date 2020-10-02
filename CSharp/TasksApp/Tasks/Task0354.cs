using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 354 - "Разложение на простые множители"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 27%)
    /// 
    /// Требуется вывести представление целого числа N в виде произведения простых чисел.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит натуральное число N (2 ≤ N ≤ 2^(31)-1).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите список простых множителей
    /// числа N в порядке неубывания, разделенных знаком «*».
    /// </summary>
    public class Task0354
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(result);
        }

        private static void GetInputData(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        public static IEnumerable<int> Solve(int n)
        {
            var i = 2;

            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    n /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            
            if (n > 1)
            {
                yield return n;
            }
        }

        private static void PrintResult(IEnumerable<int> result)
        {
            Console.Write(string.Join("*", result));
        }
    }
}
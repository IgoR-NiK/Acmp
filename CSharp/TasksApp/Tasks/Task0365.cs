using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 365 - "Разложение на слагаемые"
    /// (Время: 2 сек. Память: 16 Мб Сложность: 54%)
    /// 
    /// Требуется вывести все различные представления натурального числа N в виде суммы натуральных чисел. 
    /// Представления, отличающиеся друг от друга порядком слагаемых, не являются различными.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит целое число N (2 ≤ N ≤ 40).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите все различные представления числа N без повторов в виде суммы по одному на отдельной строке. 
    /// Как слагаемые, так и сами суммы могут следовать в произвольном порядке. 
    /// </summary>
    public class Task0365
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(1, n);

            PrintResult(result);
        }

        private static void GetInputData(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        public static List<List<int>> Solve(int max, int n)
        {
            var list = new List<List<int>>();

            for (var i = max; i <= n / 2; i++)
            {
                list.Add(new List<int> { i, n - i });
                foreach (var e in Solve(Math.Max(max, i), n - i))
                {
                    e.Add(i);
                    list.Add(e);
                }
            }

            return list;
        }

        private static void PrintResult(List<List<int>> result)
        {
            result.ForEach(r => Console.WriteLine(String.Join("+", r)));
        }
    }
}
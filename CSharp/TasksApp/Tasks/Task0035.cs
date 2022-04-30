using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 35 - "Конечные автоматы"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 11%)
    /// 
    /// Однажды известный профессор обнаружил описания k конечных автоматов. 
    /// По его мнению, нетривиальность конечного автомата, имеющего n состояний и m переходов, можно описать целым числом 
    /// d = 19m + (n + 239)*(n + 366) / 2 . Чем больше d, тем больший интерес для науки представляет изучение его свойств.
    /// Помогите профессору вычислить нетривиальность имеющихся у него автоматов.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит целое число k (1 ≤ k ≤ 10000) – количество конечных автоматов. 
    /// Следующие k строк содержат по два целых числа n(i) (0 ≤ n(i) ≤ 1000) и m(i) (0 ≤ m(i) ≤ 26*n(i)^2) – число состояний и переходов i-го автомата.
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен состоять из k строк. На i-й строке выходного файла выведите одно число – нетривиальность i-го автомата.
    /// </summary>
    public class Task0035
    {
        public static void Main()
        {
            GetInputData(out var n, out var m);

            var result = Solve(n, m);

            PrintResult(result);
        }

        private static void GetInputData(out int[] n, out int[] m)
        {
            var k = int.Parse(Console.ReadLine());

            n = new int[k];
            m = new int[k];
            for (var i = 0; i < k; i++)
            {
                var input = Console.ReadLine().Split();

                n[i] = int.Parse(input[0]);
                m[i] = int.Parse(input[1]);
            }
        }

        public static long[] Solve(int[] n, int[] m)
        {
            var result = new long[n.Length];

            for (var i = 0; i < n.Length; i++)
            {
                result[i] = 19 * m[i] + (n[i] + 239) * (n[i] + 366) / 2;
            }
            return result;
        }

        private static void PrintResult(long[] result)
        {
            Array.ForEach(result, x => Console.WriteLine(x));
        }
    }
}
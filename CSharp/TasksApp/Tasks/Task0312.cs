using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 312 - "Арифметическая прогрессия"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
    /// 
    /// Заданы первый и второй элементы арифметической прогрессии.
    /// Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит три целых числа,
    /// разделенных пробелами – первый элемент прогрессии A(1) (1 ≤ A(1) ≤ 1000), второй элемент прогрессии A(2) (1 ≤ A(2) ≤ 1000), и номер требуемого элемента N (1 ≤ N ≤ 1000).
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать одно целое число - N-й элемент арифметической прогрессии.
    /// </summary>
    public static class Task0312
    {
        public static void Main()
        {
            GetInputData(out var a1, out var a2, out var n);

            var result = Solve(a1, a2, n);

            PrintResult(result);
        }

        private static void GetInputData(out int a1, out int a2, out int n)
        {
            var input = Console.ReadLine().Split();

            a1 = int.Parse(input[0]);
            a2 = int.Parse(input[1]);
            n = int.Parse(input[2]);
        }

        public static int Solve(int a1, int a2, int n)
        {
            return a1 + (a2 - a1) * (n - 1);
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
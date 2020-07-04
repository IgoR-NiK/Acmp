using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 324 - "Четырехзначный палиндром"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
    /// 
    /// Требуется написать программу, определяющую, является ли четырехзначное натуральное число N палиндромом,
    /// т.е. числом, которое одинаково читается слева направо и справа налево.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит натуральное число N (1000 ≤ N ≤ 9999).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT следует вывести слово «YES», если число N является палиндромом, или «NO» – если нет.
    /// </summary>
    public static class Task0324
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(result);
        }

        private static void GetInputData(out string n)
        {
            n = Console.ReadLine();
        }

        public static string Solve(string n)
        {
            return n[0] == n[3] && n[1] == n[2] ? "YES" : "NO";
        }
        
        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
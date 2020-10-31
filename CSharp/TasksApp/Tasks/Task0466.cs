using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 466 - "Функция"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 42%)
    /// 
    /// Функция f(n) определена следующим образом:
    ///
    /// f(0)=0, f(1)=1, f(2n)=f(n), f(2n+1)=f(n)+f(n+1).
    ///
    /// Требуется написать программу, которая по заданному натуральному числу N определяет значение функции f(N).
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит число N (1 ≤ N ≤ 2147483647).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите значение f(N).
    /// </summary>   
    public class Task0466
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

        public static int Solve(int n)
        {
            if (n < 2) 
                return n;
            
            return n % 2 == 1 ? Solve(n / 2) + Solve(n / 2 + 1) : Solve(n / 2);
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
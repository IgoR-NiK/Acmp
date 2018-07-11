﻿using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 92 - "Журавлики"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 7%)
    /// 
    /// Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов. 
    /// Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали одинаковое количество журавликов, 
    /// а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записано одно натуральное число S – общее количество сделанных журавликов (S < 10^6).
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести три числа, разделенных пробелами – количество журавликов, 
    /// которые сделал каждый ребенок (Петя, Катя и Сережа).
    /// </summary>
    public static class Task0092
    {
        public static void Main()
        {            
            int s;
            GetInputData(out s);

            var result = Solve(s);

            PrintResult(result);  
        }

        private static void GetInputData(out int s)
        {
            s = int.Parse(Console.ReadLine());
        }

        public static Result Solve(int s)
        {
            var temp = s / 6;
            return new Result() { a = temp, b = 4 * temp, c = temp };
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }

        public struct Result
        {
            public int a;
            public int b;
            public int c;

            public override string ToString()
            {
                return string.Format("{0} {1} {2}", a, b, c);
            }
        }
    }
}
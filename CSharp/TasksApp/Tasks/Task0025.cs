using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 25 - "Больше-меньше"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 3%)
    /// 
    /// Одна из основных операций с числами – их сравнение. Мы подозреваем, что вы в совершенстве владеете этой операцией 
    /// и можете сравнивать любые числа, в том числе и целые. В данной задаче необходимо сравнить два целых числа.
    /// 
    /// Входные данные
    /// В двух строчках входного файла INPUT.TXT записаны числа A и B, не превосходящие по абсолютной величине 2*10^9.
    /// 
    /// Выходные данные
    /// Запишите в выходной файл OUTPUT.TXT один символ “<”, если A < B, “>”, если A > B и “=”, если A=B.
    /// </summary>
    public class Task0025
    {
        public static void Main()
        {
            int a, b;
            GetInputData(out a, out b);

            var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public static char Solve(int a, int b)
        {
            return a > b ? '>' : a == b ? '=' : '<';
        }

        private static void PrintResult(char result)
        {
            Console.Write(result);
        }
    }
}
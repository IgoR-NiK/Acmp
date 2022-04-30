using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 21 - "Зарплата"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 4%)
    /// 
    /// В отделе работают 3 сотрудника, которые получают заработную плату в рублях. 
    /// Требуется определить: на сколько зарплата самого высокооплачиваемого из них отличается от самого низкооплачиваемого.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записаны размеры зарплат всех сотрудников через пробел. 
    /// Каждая заработная плата – это натуральное число, не превышающее 10^5.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT необходимо вывести одно целое число — разницу между максимальной и минимальной зарплатой.
    /// </summary>
    public class Task0021
    {
        public static void Main()
        {
            GetInputData(out var a, out var b, out var c);

            var result = Solve(a, b, c);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b, out int c)
        {
            var input = Console.ReadLine().Split();

            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);
        }

        public static int Solve(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Min(b, c));
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }
    }
}
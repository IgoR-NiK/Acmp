using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 14 - "НОК"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 24%)
    /// 
    /// Требуется написать программу, определяющую наименьшее общее кратное (НОК) чисел a и b.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записаны два натуральных числа А и В через пробел, не превышающих 46340.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — НОК чисел А и В.
    /// </summary>
    public class Task0014
    {
        public static void Main()
        {
            GetInputData(out var a, out var b);

            var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b)
        {
            var input = Console.ReadLine().Split();

            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
        }

        public static int Solve(int a, int b)
        {
            var c = a * b;
            while (a * b > 0)
            {
                if (a >= b)
                    a = a % b;
                else
                    b = b % a;
            }
            var nod = a + b;
            
            return c / nod;
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }
    }
}
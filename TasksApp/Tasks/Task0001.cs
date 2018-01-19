using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 1 - "А + В"
    /// Требуется сложить два целых числа А и В.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел, не превышающих 10^9.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.   /// 
    /// </summary>
    public static class Task0001 
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
            var inputData = Console.ReadLine().Split();
            a = int.Parse(inputData[0]);
            b = int.Parse(inputData[1]);
        }

        public static int Solve(int a, int b)
        {
            return a + b;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
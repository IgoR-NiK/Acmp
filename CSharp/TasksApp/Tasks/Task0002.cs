using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 2 - "Сумма"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 19%)
    /// 
    /// Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записано единственное целое число N, не превышающее по абсолютной величине 10^4.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел, расположенных между 1 и N включительно. 
    /// </summary>
    public class Task0002
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

        public static long Solve(int n)
        {
            long sum = 0;
            var sign = n > 0 ? -1 : 1;
            while (n != 1)
            {
                sum += n;
                n += sign;
            }
            return sum + n;
        }

        private static void PrintResult(long result)
        {
            Console.WriteLine(result);
        }
    }
}
using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 59 - "Несложное вычисление"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 25%)
    /// 
    /// Задано натуральное число n. Необходимо перевести его в k-ичную систему счисления
    /// и найти разность между произведением и суммой его цифр в этой системе счисления.
    ///
    /// Например, пусть n = 239, k = 8. Тогда представление числа n в восьмеричной системе счисления — 357,
    /// а ответ на задачу равен 3 × 5 × 7 − (3 + 5 + 7) = 90.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит два натуральных числа: n и k (1 ≤ n ≤ 10^9, 2 ≤ k ≤ 10).
    /// Оба этих числа заданы в десятичной системе счисления.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите ответ на задачу (в десятичной системе счисления).
    /// </summary>
    public class Task0059
    {
        public static void Main()
        {
            GetInputData(out var n, out var k);

            var result = Solve(n, k);

            PrintResult(result);
        }

        private static void GetInputData(out int n, out int k)
        {
            var input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            k = int.Parse(input[1]);
        }

        public static int Solve(int n, int k)
        {
            var s = new int[1000];

            var l = 0;
            while (n > 0)
            {
                s[l] = n % k;
                n /= k;
                l++;
            }

            var p = 1;
            for (var i = 0; i < l; i++)
            {
                p *= s[i];
            }

            for (var i = 0; i < l; i++)
            {
                p -= s[i];
            }

            return p;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
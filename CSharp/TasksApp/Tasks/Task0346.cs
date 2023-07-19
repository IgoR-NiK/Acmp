using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 346 - "Сумма двух чисел"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 46%)
    /// 
    /// Заданы три числа: a, b, c. Необходимо выяснить, можно ли так переставить цифры в числах a и b, чтобы в сумме получилось c.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит три целых числа: a, b, c (0 ≤ a, b, c < 10^9). Числа разделены пробелом.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT следует вывести YES, если искомая перестановка цифр возможна, 
    /// в противном случае необходимо вывести NO. При положительном ответе во второй строке следует вывести число x, 
    /// получаемое перестановкой цифр числа a, и число y, получаемое перестановкой цифр числа b, сумма которых равна c. 
    /// Числа x и y при выводе не должны содержать ведущих нулей. Числа в строке разделены пробелом. 
    /// Если решений несколько, то следует вывести ту пару, в которой число x минимально.
    /// </summary>
    public class Task0346
    {
        public static void Main()
        {
            GetInputData(out var a, out var b, out var c);

            var result = Solve(a, b, c);

            PrintResult(result);
        }

        private static void GetInputData(out string a, out string b, out int c)
        {
            var numbers = Console.ReadLine().Split();

            a = numbers[0];
            b = numbers[1];
            c = int.Parse(numbers[2]);
        }

        public static Result Solve(string a, string b, int c)
        {
            var MassX = Swap((a.Length < b.Length) ? a : b);

            MassX.Sort();

            for (var i = 0; i < MassX.Count; i++)
            {
                var j = (a.Length < b.Length) ? i : MassX.Count - i - 1;
                int r = c - MassX[j];

                if (r < 0)
                {
                    if (a.Length < b.Length)
                    {
                        return new Result { Answer = false };
                    }

                    continue;
                }

                if (CheckDigit((a.Length < b.Length) ? b : a, r.ToString()))
                {
                    return new Result 
                    { 
                        Answer = true, 
                        X = a.Length < b.Length ? MassX[j] : r, 
                        Y = a.Length < b.Length ? r : MassX[j] 
                    };
                }
            }

            return new Result { Answer = false };
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);          
        }

        private static bool CheckDigit(string a, string b)
        {
            var d = new int[10];

            for (var i = 0; i < a.Length; i++)
            {
                d[a[i] - '0']++;
            }

            for (var i = 0; i < b.Length; i++)
            {
                d[b[i] - '0']--;
            }

            return d[0] >= 0 && d[1] == 0 && d[2] == 0 && d[3] == 0 && d[4] == 0 && d[5] == 0 && d[6] == 0 && d[7] == 0 && d[8] == 0 && d[9] == 0;
        }

        private static List<int> Swap(string s)
        {
            switch (s.Length)
            {
                case 1: return new List<int> { int.Parse(s) };
                case 2: return new List<int> { int.Parse(s), int.Parse($"{s[1]}{s[0]}") };
                default: return Combination(s[0] - '0', Swap(s.Substring(1)));
            }
        }

        private static List<int> Combination(int digit, List<int> numbers)
        {
            var results = new List<int>();

            foreach (var number in numbers)
            {
                int discharge = 1, whole;
                do
                {
                    whole = number / discharge;
                    results.Add(((whole * 10) + digit) * discharge + number % discharge);
                    discharge *= 10;
                } while (whole != 0);
            }
            
            return results;
        }

        public class Result
        {
            public bool Answer { get; set; }

            public int X { get; set; }

            public int Y { get; set; }

            public override string ToString() => Answer ? $"YES{Environment.NewLine}{X} {Y}" : "NO";
        }
    }
}
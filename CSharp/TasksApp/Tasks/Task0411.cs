using System;
using System.Globalization;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 411 - "Квадратное уравнение"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 28%)
    /// 
    /// Сложно найти человека, который любит решать однообразные задачки по математике.
    /// В последнее время школьникам стало легче, ведь с появлением компьютеров почти
    /// в каждой квартире стало существенно проще проверять себя.
    ///
    /// Но программы, в которых решение уравнений является стандартной функцией,
    /// установлены не везде. Напишите программу, которая сможет решить уравнение
    ///
    /// ax^2 + bx + c = 0
    ///
    /// при заданных коэффициентах a, b и c.
    /// 
    /// Входные данные
    /// Единственная строка входного файла INPUT.TXT содержит три целых числа a, b и c,
    /// каждое из которых не превосходит по модулю 30000. Числа разделяются пробелами.
    /// 
    /// Выходные данные
    /// На первой строке выходного файла OUTPUT.TXT выведите число различных действительных корней заданного уравнения.
    /// Затем выведите сами корни по одному на строке с ошибкой, не превосходящей 10^(-4).
    /// Если для заданных коэффициентов корней бесконечно много, на единственной строке выходного файла выведите -1.
    /// </summary>
    public class Task0411
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

        public static Result Solve(float a, float b, float c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                return new Result(-1);
            }
            
            if (a == 0)
            {
                if (b == 0)
                {
                    return new Result(0);
                }
                
                var result = new Result(1);
                result.Roots[0] = -c / b;
                return result;
            }

            var d = b * b - 4 * a * c;
            if (d > 0)
            {
                var x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                var x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                
                var result = new Result(2);
                result.Roots[0] = x1;
                result.Roots[1] = x2;
                return result;
            }

            if (d == 0)
            {
                var x1 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                
                var result = new Result(1);
                result.Roots[0] = x1;
                return result;
            }
            
            return new Result(0);
        }

        private static void PrintResult(Result result)
        {
            if (result.Count == -1)
            {
                Console.WriteLine(-1);
                return;
            }
                
            Console.WriteLine(result.Count);
            foreach (var root in result.Roots)
            {
                Console.WriteLine(Math.Round(root, 4).ToString(CultureInfo.InvariantCulture).Replace(',', '.'));
            }
        }
        
        public class Result
        {
            public int Count { get; }

            public float[] Roots { get; }

            public Result(int count)
            {
                Count = count;
                Roots = new float[count == -1 ? 0 : count];
            }
        }
    }
}
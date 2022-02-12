using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 1479 - "Остаток от деления"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 7%)
    /// 
    /// Напомним, как в математике определяется остаток от деления целых чисел.
    /// 
    /// Для любых целых чисел a и b (b ≠ 0) найдется единственная пара целых чисел q и r таких, что a = q*b + r, где 0 ≤ r< |b|. 
    /// 
    /// Здесь a – делимое, b – делитель, q – неполное частное, r – остаток.
    /// Следует заметить, что остаток r – это всегда неотрицательное число.
    /// 
    /// В языках программирования существуют операции для вычисления остатка от деления.
    /// Однако эти операции практически всегда в случае отрицательных чисел работают по иным правилам.
    /// 
    /// Ваша задача – по заданным числам a и b определить значение остатка от деления a на b.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит два целых числа a и b (-10^18 ≤ a, b ≤ 10^18, b ≠ 0).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите ответ на задачу.
    /// </summary>
    public static class Task1479
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b);

            var result = Solve(a, b);

            PrintResult(result);  
        }

        private static void GetInputData(out long a, out long b)
        {
	        var input = Console.ReadLine().Split();

            a = long.Parse(input[0]);
            b = long.Parse(input[1]);
        }

        public static long Solve(long a, long b)
        {
            var result = a % b;
            return result < 0 ? Math.Abs(b) + result : result;
        }

        private static void PrintResult(long result)
        {
            Console.WriteLine(result);
        }
    }
}
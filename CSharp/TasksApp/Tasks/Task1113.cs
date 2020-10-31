using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1113 - "Проверьте делимость"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
	/// 
	/// Даны два натуральных числа. Требуется проверить: делится ли одно из них на другое?
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два натуральных числа, разделенных пробелом.
	/// Числа не превосходят 100.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите 1, если одно из чисел делится на другое нацело.
	/// В противном случае следует вывести любое другое натуральное число, отличное от 1 и не превосходящее 10^9.
	/// </summary>
	public static class Task1113
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

        public static bool Solve(int a, int b)
        {
	        return a % b == 0 || b % a == 0;
        }

        private static void PrintResult(bool result)
        {
	        Console.WriteLine(result ? 1 : 2);
        }
    }
}
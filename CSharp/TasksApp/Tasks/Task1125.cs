using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1125 - "Список квадратов"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Требуется вывести квадраты натуральных чисел, не превосходящие числа N.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число N (N ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите все квадраты натуральных чисел, не превосходящие N, в порядке возрастания.
	/// </summary>
	public static class Task1125
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

        public static IEnumerable<int> Solve(int n)
        {
	        int x = 1, i = 1;
	        while (x <= n)
	        {
		        yield return x;
		        
		        i++;
		        x = i * i;
	        }
        }

        private static void PrintResult(IEnumerable<int> result)
        {
	        foreach (var number in result)
	        {
		        Console.Write($"{number} ");
	        }
        }
    }
}
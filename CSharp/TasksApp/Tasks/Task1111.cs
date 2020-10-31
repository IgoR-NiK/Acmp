using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1111 - "Число десятков"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 5%)
	/// 
	/// Требуется определить число десятков в заданном натуральном числе
	/// в его десятичной записи (то есть найти предпоследнюю цифру в числе).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число, не превосходящее 10^9.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите ответ на задачу.
	/// </summary>
	public static class Task1111
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

        public static int Solve(int n)
        {
	        return (n / 10) % 10;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
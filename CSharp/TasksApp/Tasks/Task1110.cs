using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1110 - "Последняя цифра"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 3%)
	/// 
	/// Требуется определить последнюю цифру натурального числа.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число, не превосходящее 10^9.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите последнюю цифру заданного числа.
	/// </summary>
	public static class Task1110
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
	        return n % 10;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
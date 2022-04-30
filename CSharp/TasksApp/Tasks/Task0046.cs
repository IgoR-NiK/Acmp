using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 46 - "Число E"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 20%)
	/// 
	/// Выведите в выходной файл округленное до n знаков после десятичной точки число E. 
	/// В данной задаче будем считать, что число Е в точности равно 2.7182818284590452353602875.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит целое число n (0 ≤ n ≤ 25).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите ответ на задачу.
	/// </summary>
	public class Task0046
	{
		private const string E = "2.7182818284590452353602875";

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

		public static string Solve(int n)
		{
			switch (n)
			{
				case 0:
					return "3";
				case 25:
					return E;
				default:
					return E[n + 2] >= '5' 
						? E.Substring(0, n + 1) + (char)(E[n + 1] + 1)
						: E.Substring(0, n + 2);
			}
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
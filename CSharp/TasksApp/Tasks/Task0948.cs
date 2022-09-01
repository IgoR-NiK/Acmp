using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 948 - "Строки в книге"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 13%)
    /// 
    /// В книге на одной странице помещается K строк. Таким образом, на 1-й странице печатаются строки с 1-й по K-ю,
    /// на второй — с (K+1)-й по (2∙K)-ю и т.д. Напишите программу, которая по номеру строки в тексте определяет номер страницы,
    /// на которой будет напечатана эта строка, и порядковый номер этой строки на странице.
    /// 
    /// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два числа через пробел:
	/// K – количество строк, которое печатается на странице, и число N – номер строки (1 ≤ K ≤ 200, 1 ≤ N ≤ 20000).
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите два числа – номер страницы, на которой будет напечатана эта строка и номер строки на странице.
    /// </summary>
	public class Task0948
	{
		public static void Main()
		{
			GetInputData(out var k, out var n);

			var result = Solve(k, n);

			PrintResult(result);
		}

		private static void GetInputData(out int k, out int n)
		{
			var input = Console.ReadLine().Split();

			k = int.Parse(input[0]);
			n = int.Parse(input[1]);
		}

		public static Result Solve(int k, int n) => new Result
		{
			Page = n % k == 0 ? n / k : n / k + 1,
			Row = n % k == 0 ? k : n % k
		};

		private static void PrintResult(Result result)
		{
			Console.WriteLine(result);
		}

		public struct Result
		{
			public int Page { get; set; }
			
			public int Row { get; set; }

			public Result(int page, int row)
			{
				Page = page;
				Row = row;
			}

			public override string ToString() => $"{Page} {Row}";
		}
	}
}
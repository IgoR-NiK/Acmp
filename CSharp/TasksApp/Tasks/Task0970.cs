using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 970 - "От перестановки что-то меняется ..."
    /// (Время: 1 сек. Память: 16 Мб Сложность: 9%)
    /// 
    /// Всем известно, что «от перестановки слагаемых сумма не изменяется». Однако, случается и так, что перестановка двух чисел приводит к более интересным последствиям.
	///
	/// Пусть, например, заданы три числа: a1, a2, a3. Рассмотрим равенство a1 + a2 = a3. Оно может быть неверным (например, если a1 = 1, a2 = 4, a3 = 3), 
	/// однако может стать верным, если поменять некоторые числа местами (например, если поменять местами a2 и a3, оно обратится в равенство 1 + 3 = 4).
	///
	/// Ваша задача – по заданным трем числам определить: можно ли их переставить так, чтобы сумма первых двух равнялась третьему.
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит три целых числа: a1, a2, a3 (−10^8 ≤ a1, a2, a3 ≤ 10^8).
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите слово «YES», если заданные числа можно переставить так, чтобы сумма первых двух равнялась третьему. 
	/// В противном случае выведите в выходной файл слово «NO».
    /// </summary>
	public class Task0970
	{
		public static void Main()
		{
			int a1, a2, a3;
			GetInputData(out a1, out a2, out a3);

			var result = Solve(a1, a2, a3);

			PrintResult(result);
		}

		private static void GetInputData(out int a1, out int a2, out int a3)
		{
			string[] input = Console.ReadLine().Split();

			a1 = int.Parse(input[0]);
			a2 = int.Parse(input[1]);
			a3 = int.Parse(input[2]);
		}

		public static string Solve(int a1, int a2, int a3)
		{
			return a1 + a2 == a3 || a2 + a3 == a1 || a1 + a3 == a2 ? "YES" : "NO";
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
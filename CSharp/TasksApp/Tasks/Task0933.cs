using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 933 - "Телефон"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
    /// 
    /// Услуги телефонной сети оплачиваются по следующему правилу: за разговоры до А минут в месяц – В рублей за минуту,
    /// а разговоры сверх установленной нормы оплачиваются из расчета С рублей за минуту.
    /// Требуется написать программу, вычисляющую плату за пользование телефоном для разговоров продолжительностью Т минут в месяц.
    /// 
    /// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит натуральные числа через пробел A, B, C и T, не превышающие 1000.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите единственное целое число – месячную плату за пользование телефоном.
    /// </summary>
	public class Task0933
	{
		public static void Main()
		{
			GetInputData(out var a, out var b, out var c, out var t);

			var result = Solve(a, b, c, t);

			PrintResult(result);
		}

		private static void GetInputData(out int a, out int b, out int c, out int t)
		{
			var input = Console.ReadLine().Split();
			
			a = int.Parse(input[0]);
			b = int.Parse(input[1]);
			c = int.Parse(input[2]);
			t = int.Parse(input[3]);
		}

		public static int Solve(int a, int b, int c, int t)
		{
			return Math.Min(a, t) * b + Math.Max(t - a, 0) * c;
		}

		private static void PrintResult(int result)
		{
			Console.WriteLine(result);
		}
	}
}
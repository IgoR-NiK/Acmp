using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 580 - "Поднос"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 34%)
	/// 
	/// Школьная столовая хочет заказать новые треугольные подносы. Естественно, был организован тендер.
	/// Основным критерием отбора предложений является условие того, что имеющиеся в столовой круглые тарелки
	/// должны помещаться на новые подносы.
	/// 
	/// Директор школы дал вам задание написать программу, проверяющую, помещается ли тарелка данного размера на поднос
	/// с данными длинами сторон.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT находятся 3 целых положительных числа - длины сторон подноса.
	/// Гарантируется, что поднос с такими сторонами существует. Во второй строке входного файла содержится
	/// радиус тарелки - целое положительное число. Все числа во входном файле не превосходят 100.
	/// Радиус тарелки и стороны подноса указаны в одних и тех же единицах измерения.
	/// 
	/// Выходные данные
	/// Выведите в выходной файл OUTPUT.TXT сообщение YES, если тарелка помещается на поднос, и NO - в противном случае.
	/// </summary>
	public static class Task0580
	{
		public static void Main()
		{
			GetInputData(out var a, out var b, out var c, out var r);

			var result = Solve(a, b, c, r);

			PrintResult(result);
		}

		private static void GetInputData(out int a, out int b, out int c, out int r)
		{
			var input = Console.ReadLine()?.Split();

			int.TryParse(input?[0], out a);
			int.TryParse(input?[1], out b);
			int.TryParse(input?[2], out c);
			
			int.TryParse(Console.ReadLine(), out r);
		}

		public static string Solve(int a, int b, int c, int r)
		{
			var tempR = Math.Sqrt((double)(-a + b + c) * (a - b + c) * (a + b - c) / (4 * (a + b + c)));

			return tempR >= r ? "YES" : "NO";
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
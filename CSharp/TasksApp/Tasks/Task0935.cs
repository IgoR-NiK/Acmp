using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 935 - "Шахматное поле"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 16%)
    /// 
    /// На стандартной шахматной доске 8х8 заданы координаты двух клеток. Требуется определить: имеют ли данные клетки одинаковый цвет?
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит целые числа x1, y1, x2, y2, описывающие координаты двух клеток (x1,y1) и (x2,y2).
	/// Ограничения: 1 ≤ x1,y1,x2,y2 ≤ 8.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите YES, если поля одного цвета, или слово NO в противном случае.
    /// </summary>
	public class Task0935
	{
		public static void Main()
		{
			GetInputData(out var x1, out var y1, out var x2, out var y2);

			var result = Solve(x1, y1, x2, y2);

			PrintResult(result);
		}

		private static void GetInputData(out int x1, out int y1, out int x2, out int y2)
		{
			var input = Console.ReadLine().Split();
			
			x1 = int.Parse(input[0]);
			y1 = int.Parse(input[1]);
			x2 = int.Parse(input[2]);
			y2 = int.Parse(input[3]);
		}

		public static string Solve(int x1, int y1, int x2, int y2)
		{
			return (x1 + y1) % 2 == (x2 + y2) % 2 ? "YES" : "NO";
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
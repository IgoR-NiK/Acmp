using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 706 - "Пушка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 20%)
    /// 
    /// В начале координат установлена пушка, стреляющая шариками для пинг-понга. На некотором расстоянии R от нее,
    /// параллельно оси ОХ, находится кирпичная стена бесконечной длины. Между стеной и осью OX расположена точечная цель
    /// с координатами (X,Y). Требуется нацелить пушку так, чтобы шарик ударился сначала о стену, а затем попал в цель.
    /// Определите кратчайшее расстояние от оси OY до точки соударения шарика со стеной.
    ///  
    /// Входные данные
	/// Во входном файле INPUT.TXT содержится три целых числа R, X и Y (-10 ≤ X ≤ 10, 0 ≤ Y &lt; R ≤ 10), разделенных пробелами.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите расстояние по прямой линии от оси OY до точки удара шарика о стену с точностью не худшей,
	/// чем два знака после запятой.
    /// </summary>
	public class Task0706
	{
		public static void Main()
		{
			GetInputData(out var r, out var x, out var y);

			var result = Solve(r, x, y);

			PrintResult(result);
		}

		private static void GetInputData(out double r, out double x, out double y)
		{
			var input = Console.ReadLine()?.Split();

			double.TryParse(input?[0], out r);
			double.TryParse(input?[1], out x);
			double.TryParse(input?[2], out y);
		}

		public static double Solve(double r, double x, double y)
		{
			return Math.Abs(Math.Round(x * r / (2 * r - y), 2));
		}

		private static void PrintResult(double result)
		{
			Console.WriteLine($"{result}".Replace(',', '.'));
		}
	}
}
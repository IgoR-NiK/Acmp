using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 54 - "Теория игр"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 28%)
    /// 
	/// Одним из интересных объектов, изучаемых в теории игр, являются так называемые антагонистические игры двух лиц. 
	/// Такие игры характеризуются множеством X стратегий первого игрока, множеством Y стратегий второго игрока и функцией выигрыша K(x, y) (x из X, y из Y). 
	/// Если множества стратегий X и Y конечны, то такую игру принято называть матричной, так как функцию выигрыша K в этом случае удобно задавать матрицей.
	/// 
	/// Рассмотрим матричную игру, в которой X = {1,…,n}, Y = {1,…,m}. Матрицу выигрышей обозначим символом K. 
	/// Нижним значением игры назовем число max(i=1..n)min(j=1..m) K(ij). 
	/// Верхним значением игры назовем число min(j=1..m)max(i=1..n) K(ij).
	/// Отметим также, что игры, у которых нижнее и верхнее значение совпадают, называются играми с седловой точкой.
    /// 
    /// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100). 
	/// Далее следуют n строк по m чисел в каждой. j-ое число i-ой строки равно K(ij). Все K(ij) по модулю не превосходят 1000.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите нижнее и верхнее значение игры через пробел.
    /// </summary>
	public class Task0054
	{
		public static void Main()
		{
			GetInputData(out var n, out var m, out var field);

			var result = Solve(n, m, field);

			PrintResult(result);
		}

		private static void GetInputData(out int n, out int m, out int[,] field)
		{
            var input = Console.ReadLine().Split();
			n = int.Parse(input[0]);
			m = int.Parse(input[1]);

			field = new int[n, m];
			for (var i = 0; i < n; i++)
			{
				input = Console.ReadLine().Split();
				for (var j = 0; j < m; j++)
				{
					field[i, j] = int.Parse(input[j]);
				}
			}
		}

		public static Result Solve(int n, int m, int[,] field)
		{
			var max = new int[101];
			var min = new int[101];

			max[0] = -1001;
			for (var i = 0; i < n; i++)
			{
				min[i + 1] = field[i, 0];
				for (var j = 1; j < m; j++)
				{
					if (field[i, j] < min[i + 1])
					{
						min[i + 1] = field[i, j];
					}
				}
				if (max[0] < min[i + 1])
				{
					max[0] = min[i + 1];
				}
			}

			min[0] = 1001;
			for (var j = 0; j < m; j++)
			{
				max[j + 1] = field[0, j];
				for (var i = 0; i < n; i++)
				{
					if (field[i, j] > max[j + 1])
					{
						max[j + 1] = field[i, j];
					}
				}
				if (min[0] > max[j + 1])
				{
					min[0] = max[j + 1];
				}
			}

			return new Result { Max = min[0], Min = max[0] };
        }

		private static void PrintResult(Result result)
		{
			Console.WriteLine(result);
		}

		public struct Result
		{
			public int Max;
			public int Min;

			public override string ToString()
			{
				return $"{Min} {Max}";
			}
		}
	}
}
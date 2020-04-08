using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 561 - "Башни"
	/// (Время: 2 сек. Память: 16 Мб Сложность: 95%)
	/// 
	/// Башней называется выражение вида a(0)^a(1)^a(2)^...^a(k), где k ≥ 1, т.е. последовательное возведение в степень чисел a(0), ..., a(k).
	/// Отметим, что операция возведения в степень выполняется справа налево, т.е. выражение a^b^c вычисляется как a^(b^c).
	///
	/// Аня недавно изучила алгоритмы сортировок, и теперь она умеет сортировать целые числа, вещественные числа, и даже строки.
	/// Узнав об этом, Андрюша предложил ей написать программу для сортировки башен. Как же это сделать?
	///
	/// Аня привыкла учиться на примерах, и поэтому ей нужна ваша работающая программа.
	/// Напишите программу, которая по заданным во входном файле башням вычисляла бы порядок, в котором нужно их поставить, чтобы они оказались расположены по возрастанию.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT задается число башен N (1 ≤ N ≤ 50000).
	/// Далее следуют N строк, каждая из которых содержит одну башню в формате k(i) a(i0) a(i1) ... a(iki), здесь все числа разделены пробелами.
	/// Каждое из a(ij) - целое число в пределах от 1 до 99, кроме того, 1 ≤ k(i) ≤ 9.
	/// Известно, что среди башен во входном файле нет равных.
	/// Заметьте, что значения у башен могут быть весьма велики - например, даже число 2^2^2^2^2 = 2^65536 не помещается ни в какой вещественный тип.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите перестановку номеров башен b(1), b(2), ..., b(N) в таком порядке,
	/// что если взять сначала башню с номером b(1), потом с номером b)2), и т.д., то они окажутся расположенными в порядке возрастания.
	/// </summary>
	public static class Task0561
	{
		public static void Main()
		{
			GetInputData(out var towers);

			var result = Solve(towers);

			PrintResult(result);
		}

		private static void GetInputData(out Tower[] towers)
		{
			var n = int.Parse(Console.ReadLine());

			towers = new Tower[n];
			for (var i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();

				var powers = new double[input.Length - 1];
				for (var j = 1; j < input.Length; j++)
				{
					powers[j - 1] = double.Parse(input[j]);
				}

				towers[i] = new Tower(i + 1, powers);
			}
		}

		public static IEnumerable<int> Solve(Tower[] towers)
		{
			foreach (var tower in towers)
			{
				tower.Normalization();
			}

			Array.Sort(towers, new TowerComparer());

			foreach (var tower in towers)
			{
				yield return tower.Number;
			}
		}

		private static void PrintResult(IEnumerable<int> result)
		{
			Console.WriteLine(string.Join(" ", result));
		}

		public class Tower
		{
			public int Number { get; }

			private readonly double[] _powers = new double[10];

			public Tower(int number, params double[] powers)
			{
				Number = number;
				Array.Copy(powers, _powers, powers.Length);
			}

			public double this[int index] => _powers[index];

			public void Normalization()
			{
				var k = -1;
				for (var i = 0; i < _powers.Length; i++)
				{
					if (_powers[i] == 0)
						break;

					if (_powers[i] == 1)
					{
						for (var j = i; j < _powers.Length; j++)
							_powers[j] = 0;

						k--;
					}

					k++;
				}

				while (k > 0 && _powers[k] * Math.Log10(_powers[k - 1]) < 12)
				{
					_powers[k - 1] = Math.Pow(_powers[k - 1], _powers[k]);
					_powers[k] = 0;
					k--;
				}

				switch (k)
				{
					case -1:
						_powers[0] = -1;
						break;
					case 0:
						_powers[0] = Math.Log10(Math.Log10(_powers[0]));
						break;
					case 1:
						_powers[9] = _powers[0] = Math.Log10(Math.Log10(_powers[0]));
						_powers[0] = Math.Log10(_powers[1]) + _powers[0];
						_powers[1] = 0;
						break;
					default:
						for (var q = 0; q < k - 1; q++)
							_powers[q] = Math.Log10(Math.Log10(_powers[q]));
						var r = _powers[k - 2];
						_powers[k - 2] = _powers[k] * Math.Log10(_powers[k - 1]) + _powers[k - 2];
						_powers[k] = _powers[k - 1] = 0;
						_powers[9] = r;
						break;
				}
			}
		}

		public class TowerComparer : IComparer<Tower>
		{
			public int Compare(Tower a, Tower b)
			{
				if (a.Number == b.Number)
					return 0;

				for (var i = 7; i >= 0; i--)
				{
					if (Math.Abs(a[i] - b[i]) > 1e-11)
					{
						if (a[i] > b[i])
						{
							if (b[i] != 0.0 || i == 0)
							{
								return 1;
							}

							if (b[i - 1] > a[i - 1])
							{
								if (Math.Abs(a[i] - Math.Log10(b[i - 1] - a[i - 1])) > 1e-8)
								{
									return a[i] > Math.Log10(b[i - 1] - a[i - 1]) ? 1 : -1;
								}

								if (a[i - 1] > b[9]) return 1;
								if (a[i - 1] < b[9]) return -1;

								i--;
							}
							else
							{
								return 1;
							}
						}
						else if (a[i] < b[i])
						{
							if (a[i] != 0.0 || i == 0)
							{
								return -1;
							}

							if (a[i - 1] > b[i - 1])
							{
								if (Math.Abs(b[i] - Math.Log10(a[i - 1] - b[i - 1])) > 1e-8)
								{
									return b[i] > Math.Log10(a[i - 1] - b[i - 1]) ? -1 : 1;
								}

								if (b[i - 1] > a[9]) return -1;
								if (b[i - 1] < a[9]) return 1;

								i--;
							}
							else
							{
								return -1;
							}
						}
					}
				}

				return 0;
			}
		}
	}
}
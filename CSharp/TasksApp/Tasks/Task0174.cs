﻿using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 174 - "Свадьба"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 32%)
	/// 
	/// Одна предприимчивая и очень симпатичная дамочка с прелестнейшим именем Горгона решила заработать себе денег на роскошную жизнь.
	/// N молодых людей так влюблены в нее, что предложили руку и сердце. К несчастью для них, Горгона видит в них только мешок с деньгами.
	/// Она планирует выйти замуж и почти сразу же развестись с некоторыми из молодых людей ради денежной выгоды.
	/// Все, что ей нужно, это подзаработать как можно больше денег (и уж, конечно, остаться незамужней).
	/// По законам этой прекрасной страны при разводе каждый из супругов получает половину всего имущества.
	///
	/// Вы планируете опубликовать статью, в которой опишете всю подлость и меркантильность этой особы.
	/// Для того чтобы статья получилась особенно красочной, нужно указать максимальную сумму денег, которую сможет получить Горгона.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT записано целое число N — количество молодых людей, без памяти влюбленных в Горгону (1 < N <= 40).
	/// Далее следует N чисел — сумма денег на счету каждого молодого человека. В последней строке записано целое число А — сумма денег на счету Горгоны.
	/// Суммы денег на счету — целые неотрицательные числа, не превосходящие 10^9.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите единственное число — максимальную сумму денег, которой сможет обладать Горгона после своей махинации.
	/// Ответ выводите в формате с фиксированной точкой с ровно шестью знаками после десятичной точки.
	/// </summary>
	public static class Task0174
	{
		public static void Main()
		{
			GetInputData(out var b, out var a);

			var result = Solve(b, a);

			PrintResult(result);
		}

		private static void GetInputData(out double[] b, out double a)
		{
			var n = int.Parse(Console.ReadLine());
			var input = Console.ReadLine().Split();
			a = double.Parse(Console.ReadLine());
			
			b = new double[n];
			for (var i = 0; i < n; i++)
			{
				b[i] = double.Parse(input[i]);
			}
		}

		public static string Solve(double[] b, double a)
		{
			Array.Sort(b);

			foreach (var t in b)
			{
				if (a < t)
				{
					a = (a + t) / 2;
				}
			}

			return $"{a:F6}".Replace(',', '.');
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
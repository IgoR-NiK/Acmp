using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 178 - "Преобразование последовательности"
	/// (Время: 2 сек. Память: 32 Мб Сложность: 35%)
	/// 
	/// Задана последовательность, содержащая n целых чисел. Необходимо найти число, которое встречается в этой последовательности наибольшее количество раз,
	/// а если таких чисел несколько, то найти минимальное из них, и после этого переместить все такие числа в конец заданной последовательности.
	/// Порядок расположения остальных чисел должен остаться без изменения.
	///
	/// Например, последовательность 1, 2, 3, 2, 3, 1, 2 после преобразования должна превратиться в последовательность 1, 3, 3, 1, 2, 2, 2.
	///
	/// Требуется написать программу, которая решает данную задачу.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит число n — количество чисел во входной последовательности (3 ≤ n ≤ 200000).
	/// Следующая строка содержит входную последовательность, состоящую из n целых чисел, не превышающих по модулю 10^6.
	/// Все числа в строке разделены пробелом.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выводится последовательность чисел, которая получается в результате названного преобразования.
	/// Все числа в последовательности должны быть разделены пробелом.
	/// </summary>
	public static class Task0178
	{
		public static void Main()
		{
			GetInputData(out var numbers);

			var result = Solve(numbers);

			PrintResult(result);
		}

		private static void GetInputData(out int[] numbers)
		{
			var sr = new StreamReader("input.txt");
           
			int.TryParse(sr.ReadLine(), out var n);
               
			numbers = new int[n];
			for (var i = 0; i < n; i++)
			{
				numbers[i] = ReadNumber(sr);
			}
           
			sr.Close();
		}

		public static IEnumerable<int> Solve(int[] numbers)
		{
			var copyNumbers = new int[numbers.Length + 1];
			Array.Copy(numbers, 0, copyNumbers, 1, numbers.Length);
			
			copyNumbers[0] = int.MinValue;
			
			Array.Sort(copyNumbers);

			var checkNumber = copyNumbers[copyNumbers.Length - 1];
			var maxNumber = 0;
			var k = 1;
			var p = 1;
			for (var i = copyNumbers.Length - 2; i >= 0; i--)
			{
				if (copyNumbers[i] == checkNumber)
				{
					p++;
				}
				else
				{
					if (p >= k)
					{
						k = p;
						maxNumber = copyNumbers[i + 1];
					}

					checkNumber = copyNumbers[i];
					p = 1;
				}
			}

			foreach (var num in numbers)
			{
				if (num != maxNumber)
				{
					yield return num;
				}
			}

			for (var i = 0; i < k; i++)
			{
				yield return maxNumber;
			}
		}

		private static void PrintResult(IEnumerable<int> result)
		{
			foreach (var num in result)
			{
				Console.Write($"{num} ");
			}
		}
		
		private static int ReadNumber(StreamReader sr)
		{
			var number = new StringBuilder();
   
			while (true)
			{
				var symbol = (char)sr.Read();
   
				if (char.IsDigit(symbol) || symbol == '-')
				{
					number.Append(symbol);
					continue;
				}
   
				if (number.Length != 0 || symbol == '\r')
				{
					break;
				}
			}
   
			return int.TryParse(number.ToString(), out var result)
				? result
				: throw new FormatException("Not found number in console line");
		}
	}
}
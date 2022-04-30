using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 36 - "Постулат Бертрана"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 30%)
    /// 
    /// Постулат Бертрана (теорема Бертрана-Чебышева, теорема Чебышева) гласит, что для любого n > 1 найдется простое число p в интервале n &lt; p &lt; 2n. 
	/// Такая гипотеза была выдвинута в 1845 году французским математиком Джозефем Бертраном (проверившим ее до n=3000000) и доказана в 1850 году Пафнутием Чебышевым. 
	/// Раманужан в 1920 году нашел более простое доказательство, а Эрдеш в 1932 – еще более простое.
	/// Ваша задача состоит в том, чтобы решить несколько более общую задачу – а именно по числу n найти количество простых чисел p из интервала n &lt; p &lt; 2n.
	/// Напомним, что число называется простым, если оно делится только само на себя и на единицу.
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит целое число n (2 ≤ n ≤ 50000).
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите одно число – ответ на задачу.
    /// </summary>
	public class Task0036
	{
		public static void Main()
		{
			GetInputData(out var n);

			var result = Solve(n);

			PrintResult(result);
		}

		private static void GetInputData(out int n)
		{
			n = int.Parse(Console.ReadLine());
		}

		public static int Solve(int n)
		{
			var primeNumbers = new List<int> { 2 };
			var result = primeNumbers[0] > n ? 1 : 0;

			for (var i = 3; i < 2 * n; i += 2)
			{
				var isContinue = false;
				var j = 0;
				while (primeNumbers[j] * primeNumbers[j] <= i)
				{
					j++;
					if (i % primeNumbers[j] == 0)
					{
						isContinue = true;
						break;
					}
				}

				if (isContinue)
					continue;

				primeNumbers.Add(i);

				if (i > n)
					result++;
			}

			return result;
		}

		private static void PrintResult(int result)
		{
			Console.WriteLine(result);
		}
	}
}
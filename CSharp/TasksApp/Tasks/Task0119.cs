using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 119 - "Сортировка времени"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 23%)
	/// 
	/// Требуется выполнить сортировку временных моментов, заданных в часах, минутах и секундах.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT в первой строке записано число N (1 ≤ N ≤ 100), а в последующих N строках N моментов времени. 
	/// Каждый момент времени задается 3 целыми числами - часы (от 0 до 23), минуты (от 0 до 59) и секунды (от 0 до 59).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите моменты времени, упорядоченные в порядке неубывания без ведущих нулей.
	/// </summary>
	public class Task0119
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out TimeInterval[] input)
        {
			var n = int.Parse(Console.ReadLine());

			input = new TimeInterval[n];
			for (var i = 0; i < n; i++)
			{
				var time = Console.ReadLine().Split();
				input[i] = new TimeInterval()
				{
					Hours = int.Parse(time[0]),
					Minutes = int.Parse(time[1]),
					Seconds = int.Parse(time[2])
				};
			}
        }

        public static TimeInterval[] Solve(TimeInterval[] input)
        {
			Array.Sort(input, new TimeIntervalComparer());
			return input;
        }

        private static void PrintResult(TimeInterval[] result)
        {
            foreach (var time in result)
			{
				Console.WriteLine($"{time.Hours} {time.Minutes} {time.Seconds}");
			}
        }

		public class TimeInterval
		{
			public int Hours { get; set; }
			public int Minutes { get; set; }
			public int Seconds { get; set; }
		}

		public class TimeIntervalComparer : IComparer<TimeInterval>
		{
			public int Compare(TimeInterval x, TimeInterval y)
			{
				if (x.Hours > y.Hours) return 1;
				if (x.Hours < y.Hours) return -1;

				if (x.Minutes > y.Minutes) return 1;
				if (x.Minutes < y.Minutes) return -1;

				if (x.Seconds > y.Seconds) return 1;
				if (x.Seconds < y.Seconds) return -1;

				return 0;
			}
		}
	}
}
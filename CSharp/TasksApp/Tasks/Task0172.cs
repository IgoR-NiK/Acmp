using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 172 - "Деление с остатком"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 39%)
	/// 
	/// Заданы два числа: N и K. Необходимо найти остаток от деления N на K.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит два целых числа: N и K (1 ≤ N ≤ 10^100, 1 ≤ K ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите остаток от деления N на K.
	/// </summary>
	public class Task0172
    {
        public static void Main()
        {            
            GetInputData(out var n, out var k);
						
			var result = Solve(n, k);

            PrintResult(result);
        }

        private static void GetInputData(out BigInteger n, out int k)
        {
			var input = Console.ReadLine().Split();
			n = new BigInteger(input[0]);
			k = int.Parse(input[1]);
        }

        public static int Solve(BigInteger n, int k)
        {
			return n % k;
        }

        private static void PrintResult(int result)
        {
			Console.Write(result);
        }

		public class BigInteger
		{
			// Массив, который хранит большое число
			private readonly List<int> _arr = new List<int>();

			// Количество цифр в одном элементе массива    
			private static readonly int Order = 8;

			public BigInteger() { }
			public BigInteger(string s)
			{
				int whole = s.Length / Order, rest = s.Length % Order;

				for (var i = 1; i <= whole; i++)
					_arr.Add(int.Parse(s.Substring(s.Length - Order * i, Order)));

				if (rest != 0)
					_arr.Add(int.Parse(s.Substring(0, rest)));
			}

			// Остаток от деления большого неотрицательного числа на короткое неотрицательное число
			public static int operator %(BigInteger a, int b)
			{
				int r = 0, myBase = (int)Math.Pow(10, Order);
				for (var i = a._arr.Count - 1; i >= 0; i--)
				{
					var temp = r * (long)myBase + a._arr[i];
					r = (int)(temp % b);
				}

				return r;
			}
		}
	}
}
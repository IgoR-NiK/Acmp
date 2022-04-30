using System;
using System.Collections.Generic;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 144 - "A*B"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 37%)
	/// 
	/// Даны два целых неотрицательных числа A и B. Требуется найти их произведение.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT записаны целые неотрицательные числа A и B по одному в строке (A %lt; 10^100, B ≤ 10000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите единственное число без лидирующих нулей: A*B.
	/// </summary>
	public class Task0144
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b);
						
			var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out BigInteger a, out int b)
        {
			a = new BigInteger(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
        }

        public static BigInteger Solve(BigInteger a, int b)
        {
			return a * b;
        }

        private static void PrintResult(BigInteger result)
        {
			Console.Write(result);
        }

		public class BigInteger
		{
			// Массив, который хранит большое числа
			private readonly List<int> _arr = new List<int>();

			// Количество цифр в одном элементе массива    
			private const int Order = 8;

			public BigInteger() { }
			public BigInteger(string s)
			{
				int whole = s.Length / Order, rest = s.Length % Order;

				for (var i = 1; i <= whole; i++)
					_arr.Add(int.Parse(s.Substring(s.Length - Order * i, Order)));

				if (rest != 0)
					_arr.Add(int.Parse(s.Substring(0, rest)));
			}

			// Умножение большого числа на короткое
			public static BigInteger operator *(BigInteger a, int b)
			{
				var c = new BigInteger();

				int k = 0, myBase = (int)Math.Pow(10, Order);
				for (var i = 0; i < a._arr.Count; i++)
				{
					var temp = a._arr[i] * (long)b + k;
					c._arr.Add((int)(temp % myBase));
					k = (int)(temp / myBase);
				}
				c._arr.Add(k);
				Normalize(c._arr);

				return c;
			}

			// Вывод большого числа
			public override string ToString()
			{
				var ans = new StringBuilder();

				ans.Append(_arr[_arr.Count - 1].ToString());
				for (var i = _arr.Count - 2; i >= 0; i--)
					ans.Append(_arr[i].ToString().PadLeft(Order, '0'));

				return ans.ToString();
			}

			// Удаление лидирующих нулей
			private static void Normalize(List<int> arr)
			{
				while (arr.Count > 1 && arr[arr.Count - 1] == 0)
					arr.RemoveAt(arr.Count - 1);
			}
		}
	}
}
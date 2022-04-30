using System;
using System.Collections.Generic;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 145 - "A div B"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 40%)
	/// 
	/// Даны два целых числа A и B. Требуется найти их целую часть от их частного.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT записаны целые числа A и B по одному в строке (0 ≤ A ≤ 10^100, 0 %lt; B ≤ 10000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите единственное число без лидирующих нулей: A div B.
	/// </summary>
	public class Task0145
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
			return a / b;
        }

        private static void PrintResult(BigInteger result)
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

			// Деление большого неотрицательного числа на короткое неотрицательное число
			public static BigInteger operator /(BigInteger a, int b)
			{
				var c = new BigInteger();

				int r = 0, myBase = (int)Math.Pow(10, Order);
				for (var i = a._arr.Count - 1; i >= 0; i--)
				{
					var temp = r * (long)myBase + a._arr[i];
					c._arr.Insert(0, (int)(temp / b));
					r = (int)(temp % b);
				}
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
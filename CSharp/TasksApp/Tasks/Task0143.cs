using System;
using System.Collections.Generic;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 143 - "A-B"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 44%)
	/// 
	/// Требуется найти разность между неотрицательными числами А и В.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT в двух строках записаны два неотрицательных целых числа A и B, не превышающие 10^1000.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите значение A-B.
	/// </summary>
	public class Task0143
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b);
						
			var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out BigInteger a, out BigInteger b)
        {
			a = new BigInteger(Console.ReadLine());
			b = new BigInteger(Console.ReadLine());
        }

        public static BigInteger Solve(BigInteger a, BigInteger b)
        {
			return a - b;
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
			private static readonly int Order = 8;

			// Знак числа. Число неотрицательное, если sign = true и отрицательное, если sign = false
			private bool _sign = true;

			public BigInteger() { }
			public BigInteger(string s)
			{
				int whole = s.Length / Order, rest = s.Length % Order;

				for (var i = 1; i <= whole; i++)
					_arr.Add(int.Parse(s.Substring(s.Length - Order * i, Order)));

				if (rest != 0)
					_arr.Add(int.Parse(s.Substring(0, rest)));

				Normalize(_arr);
			}

			// Вычитание двух больших неотрицательных чисел
			public static BigInteger operator -(BigInteger a, BigInteger b)
			{
				if (a.CompareTo(b) == -1)
				{
					var temp = b - a;
					temp.ChangeSign(false);
					return temp;
				}

				var c = new BigInteger();

				int k = 0, myBase = (int)Math.Pow(10, Order);
				for (var i = 0; i < a._arr.Count; i++)
				{
					var tempB = b._arr.Count > i ? b._arr[i] : 0;

					c._arr.Add(a._arr[i] - tempB - k);
					if (c._arr[i] < 0)
					{
						k = 1;
						c._arr[i] += myBase;
					}
					else
					{
						k = 0;
					}
				}
				Normalize(c._arr);

				return c;
			}

			// Сравнение двух больших неотрицательных чисел        
			public int CompareTo(BigInteger other)
			{
				var ans = 0;
				if (_arr.Count == other._arr.Count)
				{
					for (var i = _arr.Count - 1; i >= 0; i--)
					{
						if (_arr[i] > other._arr[i])
						{
							ans = 1;
							break;
						}

						if (_arr[i] < other._arr[i])
						{
							ans = -1;
							break;
						}
					}
				}
				else
				{
					ans = _arr.Count > other._arr.Count ? 1 : -1;
				}
				return ans;
			}

			// Вывод большого числа
			public override string ToString()
			{
				var ans = new StringBuilder();

				if (!_sign) ans.Append('-');
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

			// Смена знака
			public void ChangeSign(bool flag)
			{
				_sign = flag;
			}
		}
	}
}
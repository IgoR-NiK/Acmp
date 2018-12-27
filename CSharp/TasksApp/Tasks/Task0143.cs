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
			private List<int> arr = new List<int>();

			// Количество цифр в одном элементе массива    
			private static int order = 8;

			// Знак числа. Число неотрицательное, если sign = true и отрицательное, если sign = false
			private bool sign = true;

			public BigInteger() { }
			public BigInteger(string s)
			{
				int whole = s.Length / order, rest = s.Length % order;

				for (int i = 1; i <= whole; i++)
					arr.Add(int.Parse(s.Substring(s.Length - order * i, order)));

				if (rest != 0)
					arr.Add(int.Parse(s.Substring(0, rest)));

				Normalize(arr);
			}

			// Вычитание двух больших неотрицательных чисел
			public static BigInteger operator -(BigInteger A, BigInteger B)
			{
				if (A.CompareTo(B) == -1)
				{
					BigInteger temp = B - A;
					temp.ChangeSign(false);
					return temp;
				}

				BigInteger C = new BigInteger();

				int k = 0, myBase = (int)Math.Pow(10, order);
				for (int i = 0; i < A.arr.Count; i++)
				{
					int tempB = (B.arr.Count > i) ? B.arr[i] : 0;

					C.arr.Add(A.arr[i] - tempB - k);
					if (C.arr[i] < 0)
					{
						k = 1;
						C.arr[i] += myBase;
					}
					else
					{
						k = 0;
					}
				}
				Normalize(C.arr);

				return C;
			}

			// Сравнение двух больших неотрицательных чисел        
			public int CompareTo(BigInteger other)
			{
				int ans = 0;
				if (this.arr.Count == other.arr.Count)
				{
					for (int i = this.arr.Count - 1; i >= 0; i--)
					{
						if (this.arr[i] > other.arr[i])
						{
							ans = 1;
							break;
						}

						if (this.arr[i] < other.arr[i])
						{
							ans = -1;
							break;
						}
					}
				}
				else
				{
					ans = (this.arr.Count > other.arr.Count) ? 1 : -1;
				}
				return ans;
			}

			// Вывод большого числа
			public override string ToString()
			{
				StringBuilder ans = new StringBuilder();

				if (!sign) ans.Append('-');
				ans.Append(arr[arr.Count - 1].ToString());
				for (int i = arr.Count - 2; i >= 0; i--)
					ans.Append(arr[i].ToString().PadLeft(order, '0'));

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
				sign = flag;
			}
		}
	}
}
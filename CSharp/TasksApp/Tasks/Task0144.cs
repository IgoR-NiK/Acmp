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
	/// Во входном файле INPUT.TXT записаны целые неотрицательные числа A и B по одному в строке (A < 10^100, B ≤ 10000).
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
			private List<int> arr = new List<int>();

			// Количество цифр в одном элементе массива    
			private static int order = 8;

			public BigInteger() { }
			public BigInteger(string s)
			{
				int whole = s.Length / order, rest = s.Length % order;

				for (int i = 1; i <= whole; i++)
					arr.Add(int.Parse(s.Substring(s.Length - order * i, order)));

				if (rest != 0)
					arr.Add(int.Parse(s.Substring(0, rest)));
			}

			// Умножение большого числа на короткое
			public static BigInteger operator *(BigInteger A, int B)
			{
				BigInteger C = new BigInteger();

				int k = 0, myBase = (int)Math.Pow(10, order);
				for (int i = 0; i < A.arr.Count; i++)
				{
					long temp = A.arr[i] * (long)B + k;
					C.arr.Add((int)(temp % myBase));
					k = (int)(temp / myBase);
				}
				C.arr.Add(k);
				Normalize(C.arr);

				return C;
			}

			// Вывод большого числа
			public override string ToString()
			{
				StringBuilder ans = new StringBuilder();

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
		}
	}
}
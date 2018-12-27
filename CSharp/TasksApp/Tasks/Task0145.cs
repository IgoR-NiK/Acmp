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
	/// Во входном файле INPUT.TXT записаны целые числа A и B по одному в строке (0 ≤ A ≤ 10^100, 0 < B ≤ 10000).
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

			// Деление большого неотрицательного числа на короткое неотрицательное число
			public static BigInteger operator /(BigInteger A, int B)
			{
				BigInteger C = new BigInteger();

				int r = 0, myBase = (int)Math.Pow(10, order);
				for (int i = A.arr.Count - 1; i >= 0; i--)
				{
					long temp = (long)r * (long)myBase + A.arr[i];
					C.arr.Insert(0, (int)(temp / B));
					r = (int)(temp % B);
				}
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
using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 700 - "Мёд"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 23%)
    /// 
    /// Все любят сладости и, в частности, мед. Винни-Пух тоже его любит. Каждый день он шел лакомиться медом, а по дороге
    /// домой заходил в гости к Кролику. Но приближалась зима, и Винни-Пух начал задумываться о запасах. Он решил в течении
    /// N дней не лакомиться медом, а собирать полный горшочек объемом V горстей и перекладывать его в бочку.
    /// В первый день своего собирательства он так и сделал. Терпения хватило на один день. А на следующий день он не смог устоять и
    /// по дороге домой съел K горстей меда из горшочка. В каждый следующий день из полного горшочка он съедал на K горстей больше.
    ///
    /// Необходимо определить объем меда, собранного Винни-Пухом на зиму.
    ///  
    /// Входные данные
	/// Входной файл INPUT.TXT содержит три натуральных числа N (N ≤ 300), V (V ≤ 10^7) и K (K ≤ 1000). K – объем,
	/// на который Винни-Пух с каждым днем съедал больше меда.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите два значения через пробел. Сначала идет строка «NO», если случилось, что Винни-Пух
	/// пришел к Кролику с пустым горшочком и «YES» в противном случае. Второе значение – объем меда, заготовленного Винни-Пухом на зиму.
    /// </summary>
	public class Task0700
	{
		public static void Main()
		{
			GetInputData(out var n, out var v, out var k);

			var result = Solve(n, v, k);

			PrintResult(result);
		}

		private static void GetInputData(out int n, out int v, out int k)
		{
			var input = Console.ReadLine().Split();

			n = int.Parse(input[0]);
			v = int.Parse(input[1]);
			k = int.Parse(input[2]);
		}

		public static Result Solve(int n, int v, int k)
		{
			var result = new Result { Volume = 0, IsEmpty = false };
			
			for (var i = 0; i < n; i++)
			{
				if (v - i * k > 0)
				{
					result.Volume += v - i * k;
				}
				else
				{
					result.IsEmpty = true;
					break;
				}
			}
			
			return result;
		}

		private static void PrintResult(Result result)
		{
			Console.WriteLine(result);
		}
		
		public class Result
		{
			public bool IsEmpty { get; set; }
			
			public long Volume { get; set; }

			public override string ToString() => $"{(IsEmpty ? "NO" : "YES")} {Volume}";
		}
	}
}
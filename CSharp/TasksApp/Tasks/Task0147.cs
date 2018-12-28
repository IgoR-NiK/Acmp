using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 147 - "Числа Фибоначчи"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 16%)
	/// 
	/// Последовательностью Фибоначчи называется последовательность чисел a(0), a(1), ..., a(n), ..., где a(0) = 0, a(1) = 1, a(k) = a(k-1) + a(k-2) (k > 1).
	/// Требуется найти N-е число Фибоначчи.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT записано целое число N (0 ≤ N ≤ 30).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите N-е число Фибоначчи.
	/// </summary>
	public class Task0147
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
			if (n == 0) return 0;
			if (n == 1) return 1;

			var oldValue = 0;
			var value = 1;
			var temp = 0;
			for (var i = 2; i < n + 1; i++)
			{
				temp = value;
				value += oldValue;
				oldValue = temp;
			}

			return value;
        }

        private static void PrintResult(int result)
        {
			Console.Write(result);
        }
	}
}
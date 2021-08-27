using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 148 - "НОД"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
	/// 
	/// Даны два натуральных числа A и B. Требуется найти их наибольший общий делитель (НОД).
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT в единственной строке записаны натуральные числа A и B через пробел (A, B ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите НОД чисел А и В.
	/// </summary>
	public class Task0148
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b);
						
			var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b)
        {
	        var input = Console.ReadLine().Split();
	        
			a = int.Parse(input[0]);
			b = int.Parse(input[1]);
        }

        public static int Solve(int a, int b)
        {
	        while (a > 0 && b > 0)
			{
				if (a >= b)
				{
					a %= b;
				}
				else
				{
					b %= a;
				}
			}

			return a + b;
        }

        private static void PrintResult(int result)
        {
			Console.Write(result);
        }
	}
}
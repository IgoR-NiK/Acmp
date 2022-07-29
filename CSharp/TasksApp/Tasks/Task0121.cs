using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 121 - "Гвоздики"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 34%)
	/// 
	/// На прямой дощечке вбиты гвоздики. Любые два гвоздика можно соединить ниточкой. Требуется соединить некоторые пары гвоздиков ниточками так,
	/// чтобы к каждому гвоздику была привязана хотя бы одна ниточка, а суммарная длина всех ниточек была минимальна.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT записано число N - количество гвоздиков (2 ≤ N ≤ 100). 
	/// В следующей строке записано N чисел - координаты всех гвоздиков (неотрицательные целые числа, не превосходящие 10000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT нужно вывести единственное число - минимальную суммарную длину всех ниточек.
	/// </summary>
	public class Task0121
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out int[] input)
        {
			var n = int.Parse(Console.ReadLine());
			input = new int[n];

			var str = Console.ReadLine().Split();
			for (var i = 0; i < n; i++)
			{
				input[i] = int.Parse(str[i]);
			}
        }

        public static int Solve(int[] input)
        {
			var n = input.Length;

			Array.Sort(input);

			var mins = new int[n];

			mins[0] = int.MaxValue;
			mins[1] = input[1] - input[0];

			for (var i = 2; i < n; i++)
            {
				mins[i] = Math.Min(mins[i - 1], mins[i - 2]) + input[i] - input[i - 1];
            }

			return mins[n - 1];
		}

        private static void PrintResult(int result)
        {
			Console.Write(result);
        }
	}
}
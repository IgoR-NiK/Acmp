using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 149 - "Разворот"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 9%)
	/// 
	/// Дано натуральное число N и последовательность из N элементов. Требуется вывести эту последовательность в обратном порядке.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT записано натуральное число N (N ≤ 10^3). Во второй строке через пробел идут N целых чисел, по модулю не превосходящих 10^3 - элементы последовательности.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите заданную последовательность в обратном порядке.
	/// </summary>
	public class Task0149
    {
        public static void Main()
        {            
            GetInputData(out var input);
						
			var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out string[] input)
        {		
			input = Console.ReadLine().Split();
        }

        public static string[] Solve(string[] input)
        {
			Array.Reverse(input);
			return input;
        }

        private static void PrintResult(string[] result)
        {
			Console.Write(String.Join(" ", result));
        }
	}
}
using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 43 - "Нули"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 16%)
    /// 
	/// Требуется найти самую длинную непрерывную цепочку нулей в последовательности нулей и единиц.
    /// 
    /// Входные данные
	/// В единственной строке входного файла INPUT.TXT записана последовательность нулей и единиц (без пробелов). Суммарное количество цифр от 1 до 100.
    /// 
    /// Выходные данные
	/// В единственную строку выходного файла OUTPUT.TXT нужно вывести искомую длину цепочки нулей.
    /// </summary>
	public class Task0043
	{
		public static void Main()
		{
			GetInputData(out var input);

			var result = Solve(input);

			PrintResult(result);
		}

		private static void GetInputData(out string input)
		{
            input = Console.ReadLine();
		}

		public static int Solve(string input)
		{
            var max = 0;
            for (int i = 0, current = 0; i < input.Length; i++)
            {
                current = input[i] == '0' ? current + 1 : 0;
                max = Math.Max(max, current);
            }

            return max;
		}

		private static void PrintResult(int result)
		{
			Console.WriteLine(result);
		}
	}
}
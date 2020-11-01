using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1146 - "Цифра"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 6%)
	/// 
	/// Задан символ. Требуется определить: является ли он цифрой?
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит единственный символ (ASCII-код от 33 до 127).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите «Yes», если символ является цифрой, и «No» в противном случае.
	/// </summary>
	public static class Task1146
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);  
        }

        private static void GetInputData(out char input)
        {
	        input = char.Parse(Console.ReadLine());
        }

        public static string Solve(char input)
        {
	        return char.IsDigit(input) ? "Yes" : "No";
        }

        private static void PrintResult(string result)
        {
	        Console.WriteLine(result);
        }
    }
}
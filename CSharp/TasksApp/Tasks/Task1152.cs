using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1152 - "Вставка символов"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 14%)
	/// 
	/// Дана строка. Требуется между ее символами вставить символ «#» (ASCII 35).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит строку, состоящую только из английских букв. Строка содержит от 1 до 100 букв.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите строку, полученную из исходной, путем вставки символа «#» между всеми ее буквами.
	/// </summary>
	public static class Task1152
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

        public static string Solve(string input)
        {
	        for (var i = 1; i < input.Length; i += 2)
		        input = input.Insert(i, "#");

	        return input;
        }

        private static void PrintResult(string result)
        {
	        Console.WriteLine(result);
        }
    }
}
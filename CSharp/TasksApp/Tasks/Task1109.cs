using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1109 - "Следующее и предыдущее"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 4%)
	/// 
	/// Напишите программу, которая считывает целое число и выводит текст с упоминанием следующего и предыдущего для него чисел.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит целое число, не превосходящее 1000 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите текст, аналогичный приведенному в примере.
	/// При выводе следует учесть все пробелы и знаки препинания.
	/// </summary>
	public static class Task1109
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

        public static string[] Solve(int n)
        {
	        return new[]
	        {
		        $"The next number for the number {n} is {n + 1}.",
		        $"The previous number for the number {n} is {n - 1}."
	        };
        }

        private static void PrintResult(string[] results)
        {
	        foreach (var result in results)
	        {
		        Console.WriteLine(result);
	        }
        }
    }
}
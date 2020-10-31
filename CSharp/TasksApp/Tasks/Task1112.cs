using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1112 - "Сумма цифр числа"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 7%)
	/// 
	/// Найдите сумму цифр трехзначного натурального числа.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит трехзначное натуральное число.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите сумму цифр заданного числа.
	/// </summary>
	public static class Task1112
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
	        return n % 10 + n / 10 % 10 + n / 100;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
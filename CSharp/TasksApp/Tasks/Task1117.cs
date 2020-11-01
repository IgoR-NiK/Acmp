using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1117 - "Конец уроков"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// В некоторой школе занятия начинаются в 9:00. Продолжительность урока – 45 минут,
	/// после 1-го, 3-го, 5-го и т.д. уроков перемена длится 5 минут, а после 2-го, 4-го, 6-го и т.д. – 15 минут.
	///
	/// По номеру урока требуется определить время его окончания.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит целое число от 1 до 10 – номер урока.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите два целых числа: время окончания урока в часах и минутах.
	/// </summary>
	public static class Task1117
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

        public static (int h, int m) Solve(int n)
        {
	        var m = n * 45;
	        while (n != 1)
	        {
		        n--;
		        m += n % 2 == 0 ? 15 : 5;
	        }

	        return (9 + m / 60, m % 60);
        }

        private static void PrintResult((int h, int m) result)
        {
	        Console.WriteLine($"{result.h} {result.m}");
        }
    }
}
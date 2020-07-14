using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 542 - "Бит-реверс"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 25%)
	/// 
	/// Целое положительное число m записывается в двоичной системе счисления, разряды (в этой записи) переставляются в обратном порядке
	/// и число переводится в десятичную систему счисления. Получившееся число принимается за значение функции B(m).
	///
	/// Требуется написать программу, которая для заданного m вычислит B(m).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число m (m ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите значение B(m).
	/// </summary>
	public static class Task0542
    {
        public static void Main()
        {            
            GetInputData(out var m);

            var result = Solve(m);

            PrintResult(result);  
        }

        private static void GetInputData(out int m)
        {
			m = int.Parse(Console.ReadLine());
        }

        public static int Solve(int m)
        {
	        var toBase2 = ToBase2(m);
	        var result = ToBase10(toBase2);

	        return result;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }

        private static string ToBase2(int num)
        {
	        var result = "";

	        while (num > 0)
	        {
		        result += num % 2;
		        num /= 2;
	        }

	        return result == "" ? "0" : result;
        }

        private static int ToBase10(string num)
        {
	        var result = 0;

	        foreach (var ch in num)
	        {
		        result = result * 2 + (ch - '0');
	        }

	        return result;
        }
    }
}
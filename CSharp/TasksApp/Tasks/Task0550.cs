using System;
using System.Globalization;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 550 - "День программиста"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 13%)
	/// 
	/// День программиста отмечается в 255-й день года (при этом 1 января считается нулевым днем).
	/// Требуется написать программу, которая определит дату (месяц и число григорианского календаря), на которую приходится День программиста в заданном году.
	///
	/// В григорианском календаре високосным является:
	/// год, номер которого делится нацело на 400
	/// год, номер которого делится на 4, но не делится на 100
	/// 
	/// Входные данные
	/// В единственной строке входного файла INPUT.TXT записано целое число от 1 до 9999 включительно, которое обозначает номер года нашей эры.
	/// 
	/// Выходные данные
	/// В единственную строку выходного файла OUTPUT.TXT нужно вывести дату Дня программиста в формате DD/MM/YYYY,
	/// где DD — число, MM — номер месяца (01 — январь, 02 — февраль, ..., 12 — декабрь), YYYY — год в десятичной записи.
	/// </summary>
	public static class Task0550 
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

        public static DateTime Solve(int n)
        {
	        return new DateTime(n, 1, 1).AddDays(255);
        }

        private static void PrintResult(DateTime result)
        {
            Console.WriteLine(result.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
        }
    }
}
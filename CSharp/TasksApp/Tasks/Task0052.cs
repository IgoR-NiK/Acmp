using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 52 - "Счастливый билет"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
    /// 
	/// Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером. 
    /// Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех. 
    /// Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать программу, которая проверяет счастливость билета.
    /// 
    /// Входные данные
	/// В единственной строке входного файла INPUT.TXT записано одно целое число N (0 ≤ N < 10^6).
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT нужно вывести «YES», если билет с номером N счастливый и «NO» в противном случае.
    /// </summary>
	public class Task0052
	{
		public static void Main()
		{
			int n;
			GetInputData(out n);

			var result = Solve(n);

			PrintResult(result);
		}

		private static void GetInputData(out int n)
		{
            n = int.Parse(Console.ReadLine());
		}

		public static string Solve(int n)
		{
            var str = n.ToString().PadLeft(6, '0');
            return str[0] + str[1] + str[2] == str[3] + str[4] + str[5] ? "YES" : "NO";
        }

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
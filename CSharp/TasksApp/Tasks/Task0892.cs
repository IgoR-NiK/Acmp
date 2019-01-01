using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 892 - "Время года"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
	/// 
	/// По заданному номеру месяца в году требуется определить время года.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число N (N ≤ 100) – номер месяца.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите для летних месяцев значение «Summer», для зимних – «Winter», для весенних – «Spring», 
	/// для осенних – «Autumn». Если число не соответствует возможному значению месяца, то в этом случае следует вывести «Error».
	/// </summary>
	public static class Task0892
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

        public static String Solve(int n)
        {
			switch (n)
			{
				case 1:
				case 2:
				case 12:
					return "Winter";
				case 3:
				case 4:
				case 5:
					return "Spring";
				case 6:
				case 7:
				case 8:
					return "Summer";
				case 9:
				case 10:
				case 11:
					return "Autumn";
				default:
					return "Error";
			}
		}

        private static void PrintResult(String result)
        {
            Console.WriteLine(result);
        }
    }
}
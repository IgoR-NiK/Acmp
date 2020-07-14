using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 529 - "Длина отрезка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Отрезок задан координатами своих концевых точек. Требуется вычислить длину этого отрезка.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит координаты концов отрезка в формате X1 Y1 X2 Y2 . Все координаты – целые числа, не превышающие 1000 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите длину отрезка с точностью 10^(-5).
	/// </summary>
	public static class Task0529 
    {
        public static void Main()
        {            
            GetInputData(out var x1, out var y1, out var x2, out var y2);

            var result = Solve(x1, y1, x2, y2);

            PrintResult(result);  
        }

        private static void GetInputData(out int x1, out int y1, out int x2, out int y2)
        {
	        var input = Console.ReadLine().Split();
	        
			x1 = int.Parse(input[0]);
			y1 = int.Parse(input[1]);
			x2 = int.Parse(input[2]);
			y2 = int.Parse(input[3]);
        }

        public static double Solve(int x1, int y1, int x2, int y2)
        {
	        return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 5);
        }

        private static void PrintResult(double result)
        {
            Console.WriteLine($"{result}".Replace(',', '.'));
        }
    }
}
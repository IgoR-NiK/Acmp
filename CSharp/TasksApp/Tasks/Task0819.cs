using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 819 - "Прямоугольный параллелепипед"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
	/// 
	/// Прямоугольный параллелепипед - это объемная фигура, у которой шесть граней, и каждая из них является прямоугольником. 
	/// Моделями прямоугольного параллелепипеда служат классная комната, кирпич, спичечная коробка. 
	/// Длины трех ребер прямоугольного параллелепипеда, имеющих общий конец, называют его измерениями. 
	/// По заданным измерениям прямоугольного параллелепипеда Вам необходимо определить площадь его поверхности и объем.
	/// 
	/// Входные данные
	/// Единственная строка входного файла INPUT.TXT содержит разделенные пробелом три натуральных числа 
	/// A, B и С – измерения параллелепипеда, каждое из измерений не превышает 10^6.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите через пробел два целых числа: площадь поверхности и объем заданного параллелепипеда.
	/// </summary>
	public static class Task0819 
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b, out var c);

            var result = Solve(a, b, c);

            PrintResult(result);  
        }

        private static void GetInputData(out long a, out long b, out long c)
        {
            var inputData = Console.ReadLine().Split();
            a = long.Parse(inputData[0]);
            b = long.Parse(inputData[1]);
			c = long.Parse(inputData[2]);
		}

		public static Result Solve(long a, long b, long c) => new Result()
		{
			V = a * b * c,
			S = 2 * (a * b + b * c + a * c)
		};

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }

		public class Result
		{
			public long S { get; set; }
			public long V { get; set; }

			public override string ToString() => $"{S} {V}";
		}
    }
}
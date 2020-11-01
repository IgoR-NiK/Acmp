using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1237 - "Сумма матриц"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Заданы две целочисленные матрицы, каждая из которых состоит из N строк и M столбцов. Требуется вычислить их сумму.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов каждой матрицы.
	/// Далее следует описание двух матриц. Каждая матрица состоит из N строк по M целых чисел.
	/// Матрицы отделены друг от друга пустой строкой. Все числа во входных данных не превышают 100 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите матрицу, полученную в результате суммы заданных матриц.
	/// </summary>
	public static class Task1237
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b);

            var result = Solve(a, b);

            PrintResult(result);  
        }

        private static void GetInputData(out int[,] a, out int[,] b)
        {
	        var input = Console.ReadLine().Split();
	        
	        var n = int.Parse(input[0]);
	        var m = int.Parse(input[1]);

	        a = new int[n, m];
	        for (var i = 0; i < n; i++)
	        {
		        input = Console.ReadLine().Split();
		        for (var j = 0; j < m; j++)
		        {
			        a[i, j] = int.Parse(input[j]);
		        }
	        }

	        Console.ReadLine();
	        
	        b = new int[n, m];
	        for (var i = 0; i < n; i++)
	        {
		        input = Console.ReadLine().Split();
		        for (var j = 0; j < m; j++)
		        {
			        b[i, j] = int.Parse(input[j]);
		        }
	        }
        }

        public static int[,] Solve(int[,] a, int[,] b)
        {
	        var n = a.GetLength(0);
	        var m = b.GetLength(1);
	        
	        var result = new int[n, m];
	        for (var i = 0; i < n; i++)
	        {
		        for (var j = 0; j < m; j++)
		        {
			        result[i, j] = a[i, j] + b[i, j];
		        }
	        }

	        return result;
        }

        private static void PrintResult(int[,] result)
        {
	        for (var i = 0; i < result.GetLength(0); i++)
	        {
		        for (var j = 0; j < result.GetLength(1); j++)
		        {
			        Console.Write($"{result[i, j]} ");
		        }
		        
		        Console.WriteLine();
	        }
        }
    }
}
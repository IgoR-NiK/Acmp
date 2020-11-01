using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1238 - "Произведение матриц"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 21%)
	/// 
	/// Заданы две целочисленные матрицы A и B. Матрица A состоит из N строк и M столбцов,
	/// Матрица B состоит из M строк и P столбцов. Требуется вычислить произведение данных матриц A*B.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит три натуральных числа N, M и P.
	/// Далее следует описание матриц A и B. Матрица A состоит из N строк по M целых чисел.
	/// Матрица B состоит из M строк по P чисел. Матрицы отделены друг от друга пустой строкой.
	/// Все числа во входных данных не превышают 100 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите матрицу, полученную в результате произведения A*B.
	/// </summary>
	public static class Task1238
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
	        var p = int.Parse(input[2]);

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
	        
	        b = new int[m, p];
	        for (var i = 0; i < m; i++)
	        {
		        input = Console.ReadLine().Split();
		        for (var j = 0; j < p; j++)
		        {
			        b[i, j] = int.Parse(input[j]);
		        }
	        }
        }

        public static int[,] Solve(int[,] a, int[,] b)
        {
	        var n = a.GetLength(0);
	        var m = a.GetLength(1);
	        var p = b.GetLength(1);
	        
	        var result = new int[n, p];
	        for (var i = 0; i < n; i++)
	        {
		        for (var j = 0; j < p; j++)
		        {
			        var sum = 0;

			        for (var k = 0; k < m; k++)
				        sum += a[i, k] * b[k, j];
			        
			        result[i, j] = sum;
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
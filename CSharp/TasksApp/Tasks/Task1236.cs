using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1236 - "Транспонирование - 4"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
	/// 
	/// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы.
	/// В каждой из последующих N строк записаны M целых чисел – элементы матрицы.
	/// Все числа во входных данных не превышают 100 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
	/// </summary>
	public static class Task1236
    {
        public static void Main()
        {            
            GetInputData(out var numbers);

            var result = Solve(numbers);

            PrintResult(result);  
        }

        private static void GetInputData(out int[,] numbers)
        {
	        var input = Console.ReadLine().Split();
	        
	        var n = int.Parse(input[0]);
	        var m = int.Parse(input[1]);

	        numbers = new int[n, m];
	        for (var i = 0; i < n; i++)
	        {
		        input = Console.ReadLine().Split();
		        for (var j = 0; j < m; j++)
		        {
			        numbers[i, j] = int.Parse(input[j]);
		        }
	        }
        }

        public static int[,] Solve(int[,] numbers)
        {
	        var n = numbers.GetLength(0);
	        var m = numbers.GetLength(1);
	        
	        var result = new int[n, m];
	        for (var i = n - 1; i >= 0; i--)
	        {
		        for (var j = 0; j < m; j++)
		        {
			        result[n - 1 - i, j] = numbers[i, j]; 
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
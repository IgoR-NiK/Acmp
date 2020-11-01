using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1232 - "Двумерный массив"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 16%)
	/// 
	/// Задан целочисленный двумерный массив, состоящий из N строк и M столбцов.
	/// Требуется вычислить сумму элементов в каждой строке и в каждом столбце.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов двумерного массива.
	/// В каждой из последующих N строк записаны M целых чисел – элементы массива. Все числа во входных данных не превышают 100 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В первой строке выходного файла OUTPUT.TXT выведите N чисел – суммы элементов массива для каждой строки в отдельности.
	/// Во второй строке в аналогичном формате выведите M чисел – суммы элементов для каждого столбца.
	/// Третья строка должна быть пустой, а далее должны следовать N строк по M чисел – исходный массив, определенный во входных данных.
	/// </summary>
	public static class Task1232
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

        public static Result Solve(int[,] numbers)
        {
	        var result = new Result(numbers);

	        for (var i = 0; i < numbers.GetLength(0); i++)
	        {
		        var sum = 0;
		        
		        for (var j = 0; j < numbers.GetLength(1); j++)
		        {
			        sum += numbers[i, j];
		        }

		        result.RowsSum[i] = sum;
	        }

	        for (var j = 0; j < numbers.GetLength(1); j++)
	        {
		        var sum = 0;

		        for (var i = 0; i < numbers.GetLength(0); i++)
		        {
			        sum += numbers[i, j];
		        }

		        result.ColumnsSum[j] = sum;
	        }
	        
	        return result;
        }

        private static void PrintResult(Result result)
        {
	        Console.WriteLine(string.Join(" ", result.RowsSum));
	        Console.WriteLine(string.Join(" ", result.ColumnsSum));
	        Console.WriteLine();
	        
	        for (var i = 0; i < result.Numbers.GetLength(0); i++)
	        {
		        for (var j = 0; j < result.Numbers.GetLength(1); j++)
		        {
			        Console.Write($"{result.Numbers[i, j]} ");
		        }
		        
		        Console.WriteLine();
	        }
        }

        public class Result
        {
	        public int[,] Numbers { get; set; }
	        
	        public int[] RowsSum { get; set; }
	        
	        public int[] ColumnsSum { get; set; }

	        public Result(int[,] numbers)
	        {
		        Numbers = numbers;
		        RowsSum = new int[numbers.GetLength(0)];
		        ColumnsSum = new int[numbers.GetLength(1)];
	        }
        }
    }
}
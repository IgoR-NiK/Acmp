using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1132 - "Длина последовательности"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 11%)
	/// 
	/// Задана последовательность неотрицательных целых чисел. Требуется определить длину последовательности,
	/// завершающуюся первым встретившимся нолем (число 0 не входит в последовательность).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100.
	/// Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите целое число – длину последовательности.
	/// </summary>
	public static class Task1132
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);  
        }

        private static void GetInputData(out string[] input)
        {
	        input = Console.ReadLine().Split();
        }

        public static int Solve(string[] input)
        {
	        var result = 0;
	        
	        foreach (var n in input)
	        {
		        if (n == "0")
			        break;

		        result++;
	        }

	        return result;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
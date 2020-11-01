using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1214 - "Линейный поиск"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит натуральное число N – количество элементов в массиве.
	/// Во второй строке записаны N целых чисел A(i), разделенные пробелом.
	/// Третья строка содержит число X. Все числа во входных данных не превосходят 1000 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите количество вхождений числа X в массив A.
	/// </summary>
	public static class Task1214
    {
        public static void Main()
        {            
            GetInputData(out var numbers, out var search);

            var result = Solve(numbers, search);

            PrintResult(result);  
        }

        private static void GetInputData(out int[] numbers, out int search)
        {
	        var n = int.Parse(Console.ReadLine());
	        var str = Console.ReadLine().Split();

	        numbers = new int[n];
	        for (var i = 0; i < n; i++)
		        numbers[i] = int.Parse(str[i]);

	        search = int.Parse(Console.ReadLine());
        }

        public static int Solve(int[] numbers, int search)
        {
	        var result = 0;

	        for (var i = 0; i < numbers.Length; i++)
	        {
		        if (search == numbers[i]) 
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
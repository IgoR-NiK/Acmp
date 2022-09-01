using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 757 - "Спирт"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
	/// 
	/// Каждому школьнику из курса органической химии известна формула молекулы этилового спирта – C(2)H(5)(OH).
	/// Откуда видно, что молекула спирта состоит из двух атомов углерода (C), шести атомов водорода (H) и одного атома кислорода (O).
	///
	/// По заданному количеству атомов каждого из описанных выше элементов требуется определить максимально возможное
	/// количество молекул спирта, которые могут образоваться в процессе их соединения.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит 3 натуральных числа: C, Н и O – количество атомов углерода,
	/// водорода и кислорода соответственно. Все числа разделены пробелом и не превосходят 10^18.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите максимально возможное число молекул спирта, которые могут получиться из атомов, представленных во входных данных.
	/// </summary>
	public static class Task0757
    {
        public static void Main()
        {            
            GetInputData(out var c, out var h, out var o);

            var result = Solve(c, h, o);

            PrintResult(result);  
        }

        private static void GetInputData(out long c, out long h, out long o)
        {
            var inputData = Console.ReadLine().Split();
            c = long.Parse(inputData[0]);
            h = long.Parse(inputData[1]);
            o = long.Parse(inputData[2]);
		}

        public static long Solve(long c, long h, long o)
        {
	        return Math.Min(Math.Min(c / 2, h / 6), o);
        }

        private static void PrintResult(long result)
        {
            Console.WriteLine(result);
        }
    }
}
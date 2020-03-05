using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 664 - "Котлеты"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 30%)
	/// 
	/// На сковородке одновременно можно положить k котлет. Каждую котлету нужно с каждой стороны обжаривать m минут непрерывно.
	/// За какое наименьшее время удастся поджарить с обеих сторон n котлет?
	/// 
	/// Входные данные
	/// В единственной строке входного файла INPUT.TXT записано три натуральных числа: k, m, n, не превышающих 30000.
	/// 
	/// Выходные данные
	/// В единственную строку выходного файла OUTPUT.TXT нужно вывести единственное число – минимальное время,
	/// за которое можно поджарить все котлеты.
	/// </summary>
	public static class Task0664 
    {
        public static void Main()
        {            
            GetInputData(out var k, out var m, out var n);

            var result = Solve(k, m, n);

            PrintResult(result);  
        }

        private static void GetInputData(out int k, out int m, out int n)
        {
	        var input = Console.ReadLine().Split();
 
	        k = int.Parse(input[0]);
	        m = int.Parse(input[1]);
	        n = int.Parse(input[2]);			
        }

        public static int Solve(int k, int m, int n)
        {
	        if (n % k == 0)
	        {
		        return 2 * m * n / k;
	        }

	        if (n % k <= k / 2 && k < n)
	        {
		        return (2 * (n / k + 1) - 1) * m;
	        }

	        return 2 * (n / k + 1) * m;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
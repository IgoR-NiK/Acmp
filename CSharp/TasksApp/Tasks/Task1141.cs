using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1141 - "Равные элементы"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 19%)
	/// 
	/// Дана последовательность натуральных чисел, завершающаяся числом 0.
	/// Требуется определить, какое наибольшее число подряд идущих элементов этой последовательности равны друг другу.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100.
	/// Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите целое число – ответ на задачу.
	/// </summary>
	public static class Task1141
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
	        int i = 1, a1, a2, t = 0, max = 0;
	        a1 = int.Parse(input[0]);
	        while (a1 != 0)
	        {
		        a2 = int.Parse(input[i]);
		        if (a2 == a1)
		        {
			        t++;
			        if (t > max) max = t;
		        }
		        else
		        {
			        t = 0;
		        }
  
		        a1 = a2;
  
		        i++;
	        }
 
	        return max + 1;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
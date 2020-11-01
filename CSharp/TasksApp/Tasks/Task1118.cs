using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1118 - "Улитка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 24%)
	/// 
	/// Улитка ползет по вертикальному шесту высотой H метров, поднимаясь за день на A метров,
	/// а за ночь спускаясь на B метров. На какой день улитка доползет до вершины шеста?
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральные числа H, A и B. Ограничения: H ≤ 1000, B < A ≤ 100.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите натуральное число – количество дней, необходимых улитке для достижения вершины шеста.
	/// </summary>
	public static class Task1118
    {
        public static void Main()
        {            
            GetInputData(out var h, out var a, out var b);

            var result = Solve(h, a, b);

            PrintResult(result);  
        }

        private static void GetInputData(out int h, out int a, out int b)
        {
	        var input = Console.ReadLine().Split();
	        h = int.Parse(input[0]);
	        a = int.Parse(input[1]);
	        b = int.Parse(input[2]);
        }

        public static int Solve(int h, int a, int b)
        {
	        var result = 1;

	        for (var i = a; i < h; result++)
	        {
		        i += a - b;
	        }

	        return result;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
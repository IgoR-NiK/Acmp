using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 766 - "Орешки"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 3%)
	/// 
	/// Белочка собрала в лесу N шишек c орешками. Белочка очень привередливо выбирала шишки, и брала только те, в которых ровно M орешков. 
	/// Также известно, что для пропитания зимой ей необходимо не менее K орешков. Определите, хватит ли на зиму орешков белочке.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит три натуральных числа: N, M и K (N, M ≤ 100, K ≤ 10 000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите «YES» если белочке хватит орешков и «NO» в противном случае.
	/// </summary>
	public static class Task0766 
    {
        public static void Main()
        {            
            GetInputData(out var n, out var m, out var k);

            var result = Solve(n, m, k);

            PrintResult(result);  
        }

        private static void GetInputData(out int n, out int m, out int k)
        {
			var input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
			k = int.Parse(input[2]);
		}

        public static string Solve(int n, int m, int k)
        {
            return n * m < k ? "NO" : "YES";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
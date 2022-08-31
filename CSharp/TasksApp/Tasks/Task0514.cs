using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 514 - "Лестница"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 14%)
	/// 
	/// Мальчик Петя строит из кубиков лестницу.
	/// Лестница представляет собой несколько строящихся рядом башенок из кубиков, каждая из которых ровно на один кубик выше предыдущей.
	/// Требуется по имеющемуся у мальчика Пети числу кубиков определить, какой в кубиках будет высота последней ступеньки.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит число К – количество кубиков у мальчика Пети (1 ≤ K ≤ 10^6).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите количество кубиков в последней ступеньке у максимально высокой лестницы, которую можно построить из K кубиков.
	/// </summary>
	public static class Task0514
    {
        public static void Main()
        {            
            GetInputData(out var k);

            var result = Solve(k);

            PrintResult(result);  
        }

        private static void GetInputData(out int k)
        {
	        k = int.Parse(Console.ReadLine());
        }

        public static int Solve(int k)
        {
	        return (int)((-1 + Math.Sqrt(1 + 8 * k)) / 2);
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
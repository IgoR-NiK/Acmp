using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 903 - "Бисер"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 2%)
	/// 
	/// В шкатулке хранится разноцветный бисер (или бусины). Все бусины имеют одинаковую форму, размер и вес.
	/// Бусины могут быть одного из N различных цветов. В шкатулке много бусин каждого цвета.
	/// Требуется определить минимальное число бусин, которые можно не глядя вытащить из шкатулки так, чтобы среди них гарантированно были две бусины одного цвета.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит одно натуральное число N - количество цветов бусин (1 ≤ N ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите ответ на поставленную задачу.
	/// </summary>
	public static class Task0903 
    {
        public static void Main()
        {      
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(result);  
        }

        private static void GetInputData(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        public static int Solve(int n)
        {
            return n + 1;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
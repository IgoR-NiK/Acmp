using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1115 - "Дележ яблок"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
	/// 
	/// N школьников желают разделить K яблок между собой. Они рассматривают два способа дележа:
	///
	/// 1. разделить яблоки поровну так, чтобы каждому досталось максимальное количество яблок,
	/// при этом оставшиеся яблоки можно положить в корзину;
	///
	/// 2. разделить все яблоки так, чтобы количество яблок, доставшихся любым двум школьникам,
	/// отличалось бы не более, чем на 1. В этом случае могут обидеться те из них,
	/// кому достанется яблок меньше, чем другим.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральные числа N и K – количество школьников и яблок соответственно (N,K ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите три целых числа через пробел:
	///
	/// a) количество яблок, которые достанутся всем школьником при первом способе дележа;
	/// b) количество яблок, которые окажутся в корзине при первом способе дележа;
	/// c) количество обиженных школьников во втором случае дележа.
	/// </summary>
	public static class Task1115
    {
        public static void Main()
        {            
            GetInputData(out var n, out var k);

            var result = Solve(n, k);

            PrintResult(result);  
        }

        private static void GetInputData(out int n, out int k)
        {
	        var str = Console.ReadLine().Split();
	        n = int.Parse(str[0]);
	        k = int.Parse(str[1]);
        }

        public static (int a, int b, int c) Solve(int n, int k)
        {
	        return ((int)Math.Floor((double)k / n), k % n, k % n == 0 ? 0 : n - k % n);
        }

        private static void PrintResult((int a, int b, int c) result)
        {
	        Console.WriteLine($"{result.a} {result.b} {result.c}");
        }
    }
}
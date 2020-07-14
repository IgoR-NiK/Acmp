using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 554 - "Пицца"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 20%)
	/// 
	/// Пицца – любимое лакомство Васи, он постоянно покупает и с удовольствием употребляет различные сорта этого великолепного блюда.
	/// Однажды, в очередной раз, разрезая круглую пиццу на несколько частей, Вася задумался: на какое максимальное количество частей можно разрезать пиццу за N прямых разрезов?
	///
	/// Помогите Васе решить эту задачу, определив максимальное число не обязательно равных кусков, которые может получить Вася, разрезая пиццу таким образом.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число N – число прямых разрезов пиццы (N ≤ 1000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите ответ на задачу.
	/// </summary>
	public static class Task0554 
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
	        var sum = 1;
	        
	        for (var i = 0; i <= n; i++)
	        {
		        sum += i;
	        }
	        
			return sum;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
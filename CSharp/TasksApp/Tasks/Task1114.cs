using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1114 - "МКАД"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 11%)
	/// 
	/// Длина Московской кольцевой автомобильной дороги —109 километров.
	/// Байкер Вася стартует с первого километра МКАД и едет со скоростью V километров в час.
	/// На какой отметке он остановится через T часов?
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два целых числа V и T – скорость (км/ч)
	/// и время поездки в часах соответственно. Числа разделены пробелом. Если V>0,
	/// то Вася движется в положительном направлении по МКАД, если же значение V&lt;0,
	/// то в отрицательном. Ограничения: |V| ≤ 1000, 0 ≤ T ≤ 1000.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите целое число от 1 до 109 – километр МКАД, на котором остановится Вася.
	/// </summary>
	public static class Task1114
    {
        public static void Main()
        {            
            GetInputData(out var v, out var t);

            var result = Solve(v, t);

            PrintResult(result);  
        }

        private static void GetInputData(out int v, out int t)
        {
	        var str = Console.ReadLine().Split();
	        v = int.Parse(str[0]);
	        t = int.Parse(str[1]);
        }

        public static int Solve(int v, int t)
        {
	        var result = Math.Abs(v * t) % 109;
	        
	        result = v < 0
		        ? 110 - result
		        : result + 1;
	        
	        if (result == 110) 
		        result = 1;

	        return result;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
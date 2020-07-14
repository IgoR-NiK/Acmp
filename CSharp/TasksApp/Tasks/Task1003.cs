using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1003 - "Магазин канцелярских товаров"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 3%)
	/// 
	/// Однажды, посетив магазин канцелярских товаров, Вася купил X карандашей, Y ручек и Z фломастеров.
	/// Известно, что цена ручки на 2 рубля больше цены карандаша и на 7 рублей меньше цены фломастера.
	/// Также известно, что стоимость карандаша составляет 3 рубля. Требуется определить общую стоимость покупки.
	/// 
	/// Входные данные
	/// В единственной строке входного файла INPUT.TXT записаны три натуральных числа X, Y и Z через пробел, каждое из которых не превышает 10^9.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите одно целое число – стоимость покупки в рублях.
	/// </summary>
	public static class Task1003
    {
        public static void Main()
        {            
            GetInputData(out var x, out var y, out var z);

            var result = Solve(x, y, z);

            PrintResult(result);  
        }

        private static void GetInputData(out long x, out long y, out long z)
        {
            var inputData = Console.ReadLine().Split();
            
            x = int.Parse(inputData[0]);
            y = int.Parse(inputData[1]);
            z = int.Parse(inputData[2]);
        }

        public static long Solve(long x, long y, long z)
        {
	        var costX = 3;
	        var costY = costX + 2;
	        var costZ = costY + 7;

	        return costX * x + costY * y + costZ * z;
        }

        private static void PrintResult(long result)
        {
            Console.WriteLine(result);
        }
    }
}
using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 755 - "Сбор земляники"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 6%)
	/// 
	/// Маша и Миша собирали землянику. Маше удалось сорвать X ягод, а Мише – Y ягод. Поскольку ягода была очень вкусной, 
	/// то ребята могли какую то часть ягод съесть. По нашим подсчетам вместе они съели Z ягод.
	///
	/// Требуется определить: сколько ягод ребята собрали в результате, при этом следует проверить, не ошиблись ли мы в расчетах, 
	/// подсчитывая количество съеденных ягод (их не должно было получиться больше, чем сорванных ягод).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит три натуральных числа X, Y и Z, не превышающих 1000. Все числа расположены в первой строке файла и разделены пробелом.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите количество собранных ягод, если наши подсчеты оказались правдоподобными, либо слово «Impossible» в противном случае.
	/// </summary>
	public static class Task0755
    {
        public static void Main()
        {            
            GetInputData(out var x, out var y, out var z);

            var result = Solve(x, y, z);

            PrintResult(result);  
        }

        private static void GetInputData(out int x, out int y, out int z)
        {
            var inputData = Console.ReadLine().Split();
            x = int.Parse(inputData[0]);
            y = int.Parse(inputData[1]);
			z = int.Parse(inputData[2]);
		}

        public static string Solve(int x, int y, int z)
        {
            return x + y < z ? "Impossible" : $"{x + y - z}";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
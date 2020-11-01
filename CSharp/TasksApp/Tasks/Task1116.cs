using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1116 - "Разность времен"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 9%)
	/// 
	/// Даны значения двух моментов времени, принадлежащих одним и тем же суткам:
	/// часы, минуты и секунды для каждого из моментов времени. Известно, что второй момент
	/// времени наступил не раньше первого. Определите, сколько секунд прошло между двумя моментами времени.
	/// Программа на вход получает три целых числа – часы, минуты, секунды, задающие первый момент времени
	/// и три целых числа, задающих второй момент времени. Выведите число секунд между этими моментами времени.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит две строки, в каждой из них записан момент времени:
	/// в первой строке – начальный, во второй – конечный. Каждое описание времени состоит
	/// из трех целых неотрицательных чисел: H, M и S – часы, минуты и секунды (H ≤ 23, M ≤ 59, S ≤ 59).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите одно неотрицательное целое число – число секунд между заданными моментами времени.
	/// </summary>
	public static class Task1116
    {
        public static void Main()
        {            
            GetInputData(out var h1, out var m1, out var s1, out var h2, out var m2, out var s2);

            var result = Solve(h1, m1, s1, h2, m2, s2);

            PrintResult(result);  
        }

        private static void GetInputData(out int h1, out int m1, out int s1, out int h2, out int m2, out int s2)
        {
	        var str = Console.ReadLine().Split();
	        h1 = int.Parse(str[0]);
	        m1 = int.Parse(str[1]);
	        s1 = int.Parse(str[2]);
	        
	        str = Console.ReadLine().Split();
	        h2 = int.Parse(str[0]);
	        m2 = int.Parse(str[1]);
	        s2 = int.Parse(str[2]);
        }

        public static int Solve(int h1, int m1, int s1, int h2, int m2, int s2)
        {
	        return (h2 - h1) * 3600 + (m2 - m1) * 60 + s2 - s1;
        }

        private static void PrintResult(int result)
        {
	        Console.WriteLine(result);
        }
    }
}
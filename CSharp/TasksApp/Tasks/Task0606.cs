using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 606 - "Треугольник - 3"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Даны длины трех отрезков. Требуется проверить: могут ли они являться сторонами невырожденного треугольника.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит 3 натуральных числа X Y Z через пробел – длины заданных отрезков. Длины отрезков не превышают 1000.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите YES, если отрезки могут быть сторонами треугольника и NO в противном случае.
	/// </summary>
	public static class Task0606 
    {
        public static void Main()
        {            
            GetInputData(out var a, out var b, out var c);

            var result = Solve(a, b, c);

            PrintResult(result);  
        }

        private static void GetInputData(out int a, out int b, out int c)
        {
	        var input = Console.ReadLine().Split();
 
	        a = int.Parse(input[0]);
	        b = int.Parse(input[1]);
	        c = int.Parse(input[2]);			
        }

        public static bool Solve(int a, int b, int c)
        {
	        return a + b > c && a + c > b && b + c > a;
        }

        private static void PrintResult(bool result)
        {
            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}
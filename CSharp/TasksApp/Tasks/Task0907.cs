using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 907 - "Мышка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 9%)
	/// 
	/// Однажды компьютерная мышка подумала, что стоит взять про запас еще один коврик. Чтобы никто не заметил запасного коврика, мышка решила его спрятать под свой прямоугольный коврик. 
	/// Пробравшись ночью на склад, мышка обнаружила там только круглые коврики. Удастся ли мышке спрятать круглый коврик под прямоугольным ковриком?
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит три натуральных числа: W, H и R, где W и H - ширина и высота прямоугольного коврика, а R – радиус запасного коврика. Все числа не превосходят значения 10^9.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите «YES», если новый коврик можно спрятать под старым, и слово «NO», если этого сделать нельзя.
	/// </summary>
	public static class Task0907 
    {
        public static void Main()
        {            
            GetInputData(out var w, out var h, out var r);

            var result = Solve(w, h, r);

            PrintResult(result);  
        }

        private static void GetInputData(out int w, out int h, out int r)
        {
            var inputData = Console.ReadLine().Split();
            w = int.Parse(inputData[0]);
            h = int.Parse(inputData[1]);
			r = int.Parse(inputData[2]);
		}

        public static string Solve(int w, int h, int r)
        {
            return Math.Min(w, h) >= 2 * r ? "YES" : "NO";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
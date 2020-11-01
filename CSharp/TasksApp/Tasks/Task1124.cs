using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1124 - "Пешка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 18%)
	/// 
	/// Напомним, что в шахматах используется клеточная доска размером 8х8, где располагаются шахматные фигуры,
	/// которые могут перемещаться по определенным правилам.
	/// В частности, пешка ходит на 1 поле вперед по вертикали, начиная в начале игры свое движение со второй линии,
	/// при первом ходе пешка может перемещаться на 2 поля вперед по вертикали.
	/// Будем рассматривать только свободный ход пешки, т.е. тот случай, когда пешка перемещается в пустое поле.
	///
	/// Требуется определить: может ли пешка выполнить ход из клетки с координатами (X1,Y1)
	/// в клетку с координатами (X2,Y2) на стандартной шахматной доске?
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит два целых числа X1 и Y1 – начальную координату пешки.
	/// Во второй строке записана конечная координата – целые числа X2 и Y2 (1 ≤ X1,Y1,X2,Y2 ≤ 8).
	/// Гарантируется, что начальная и конечная координаты не совпадают.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите «YES», если ход является допустимым, и «NO» - в противном случае.
	/// </summary>
	public static class Task1124
    {
        public static void Main()
        {            
            GetInputData(out var x1, out var y1, out var x2, out var y2);

            var result = Solve(x1, y1, x2, y2);

            PrintResult(result);  
        }

        private static void GetInputData(out int x1, out int y1, out int x2, out int y2)
        {
	        var input = Console.ReadLine().Split();
	        x1 = int.Parse(input[0]);
	        y1 = int.Parse(input[1]);
	        
	        input = Console.ReadLine().Split();
	        x2 = int.Parse(input[0]);
	        y2 = int.Parse(input[1]);
        }

        public static string Solve(int x1, int y1, int x2, int y2)
        {
	        return x1 == x2 && y1 != 1 && (y2 - y1 == 1 || y2 - y1 == 2 && y1 == 2) ? "YES" : "NO";
        }

        private static void PrintResult(string result)
        {
	        Console.WriteLine(result);
        }
    }
}
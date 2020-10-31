using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1088 - "Шахматные фигуры"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 27%)
	/// 
	/// По заданным координатам двух клеток шахматной доски необходимо определить список шахматных фигур,
	/// которые могут перемещаться при игре за «белых» по правилам шахмат из первой координаты во вторую без взятия фигуры соперника.
	///
	/// Напомним, что для игры в шахматы используется доска размером 8х8. При этом горизонтальная координата нумеруется
	/// английскими буквами от «A» до «H», а вертикальная – цифрами от 1 до 8 снизу вверх.
	/// Таким образом, координата клетки состоит из буквы и цифры. Например, «H1» и «A8» – правый нижний и левый верхний углы соответственно.
	///
	/// Всего существует 6 шахматных фигур: ладья, слон, конь, ферзь, король и пешка. Опишем правила выполнения хода без взятия на свободной доске:
	/// король ходит на расстояние 1 по вертикали, горизонтали или диагонали;
	/// ферзь ходит на любое расстояние по вертикали, горизонтали или диагонали;
	/// ладья ходит на любое расстояние по вертикали или горизонтали;
	/// слон ходит на любое расстояние по диагонали;
	/// конь ходит буквой «Г», т.е. на поле, находящееся на расстоянии 2 по вертикали и 1 по горизонтали или 1 по вертикали и 2 по горизонтали;
	/// пешка ходит на 1 поле вперед по вертикали, начиная свое движение со второй линии, при первом ходе пешка может перемещаться на 2 поля вперед по вертикали.
	/// 
	/// Входные данные
	/// В первой строке входного файла INPUT.TXT через пробел записаны начальная и конечная координаты шахматной доски.
	/// Каждая координата состоит из заглавной английской буквы от «A» до «H» и цифры от 1 до 8.
	/// Гарантируется, что начальная и конечная координаты не совпадают.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите по-английски названия шахматных фигур, которые могут совершить свободный
	/// ход из первой координаты во вторую по правилам шахмат. Если ни одна из фигур не может выполнить такой ход,
	/// то следует вывести «Nobody». Фигуры следует выводить без повторов в произвольном порядке.
	/// </summary>
	public static class Task1088
    {
        public static void Main()
        {            
            GetInputData(out var point1, out var point2);

            var result = Solve(point1, point2);

            PrintResult(result);  
        }

        private static void GetInputData(out string point1, out string point2)
        {
	        var input = Console.ReadLine().Split();

	        point1 = input[0];
	        point2 = input[1];
        }

        public static string[] Solve(string point1, string point2)
        {
	        var x1 = point1[0] - 'A' + 1;
	        var y1 = point1[1] - '0';

	        var x2 = point2[0] - 'A' + 1;
	        var y2 = point2[1] - '0';
	        
	        byte mask = 0;
	        if (x1 == x2 || y1 == y2)
	        {
		        mask |= 32;
		        mask |= 4;
		        if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
		        {
			        mask |= 2;
		        }
		        if (x1 == x2 && y1 != 1)
		        {
			        if (y2 - y1 == 1 || y2 - y1 == 2 && y1 == 2)
			        {
				        mask |= 1;
			        }
		        }
	        }
	        if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
	        {
		        mask |= 16;
		        mask |= 4;
		        if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
		        {
			        mask |= 2;
		        }
	        }
	        if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1)
	        {
		        mask |= 8;
	        } 
             
	        if (mask == 0)
	        {
		        return new[] { "Nobody" };
	        }
	        
	        var results = new List<string>();
	        
	        var output = Convert.ToString(mask, 2);
	        for (var i = 0; i < output.Length; i++)
	        {
		        if (output[output.Length - i - 1] == '1')
		        {
			        switch (i)
			        {
				        case 0: results.Add("Pawn"); break;
				        case 1: results.Add("King"); break;
				        case 2: results.Add("Queen"); break;
				        case 3: results.Add("Knight"); break;
				        case 4: results.Add("Bishop"); break;
				        case 5: results.Add("Rook"); break;
			        }
		        }
	        }

	        return results.ToArray();
        }

        private static void PrintResult(string[] results)
        {
	        foreach (var result in results)
	        {
		        Console.WriteLine(result);
	        }
        }
    }
}
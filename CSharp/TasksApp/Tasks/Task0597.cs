using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 597 - "Внеземные гости"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 10%)
	/// 
	/// Недавно на поле фермера Джона были обнаружены следы приземления летающих тарелок. Об этом даже писала газета Mew Yorc Courier.
	///
	/// Поле фермера Джона имеет форму круга радиусом r1. По сообщениям журналистов были обнаружены два следа от летающих тарелок, 
	/// имевшие форму кругов. Один из них имел радиус r2, второй - радиус r3. Также сообщается, что они находились внутри поля фермера Джона 
	/// и не пересекались, ни один из них не лежал внутри другого. При этом, они, возможно, касались друг друга и/или границы поля.
	/// 
	/// Поскольку журналисты часто склонны преувеличивать масштабы событий, необходимо написать программу, 
	/// которая будет проверять, могли ли иметь место события, описанные в газете.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит три целых положительных числа - r1, r2, r3 (1 ≤ r1, r2, r3 ≤ 10^9).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите слово YES, если информация, опубликованная в газете, может соответствовать правде, и слово NO - иначе.
	/// </summary>
	public static class Task0597 
    {
        public static void Main()
        {            
            GetInputData(out var r1, out var r2, out var r3);

            var result = Solve(r1, r2, r3);

            PrintResult(result);  
        }

        private static void GetInputData(out int r1, out int r2, out int r3)
        {
			var input = Console.ReadLine().Split();
			r1 = int.Parse(input[0]);
			r2 = int.Parse(input[1]);
			r3 = int.Parse(input[2]);
		}

        public static String Solve(int r1, int r2, int r3)
        {
			return r1 >= r2 + r3 ? "YES" : "NO";
        }

        private static void PrintResult(String result)
        {
            Console.WriteLine(result);
        }
    }
}
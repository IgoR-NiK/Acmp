﻿using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 940 - "Орфография"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 13%)
    /// 
    /// У студента-филолога Васи есть замечательный друг Петя. И Петя никак не может выучить английский язык.
    /// Английский текст Петя еще кое-как читает, но пишет с ужасными ошибками, причем чаще всего он вставляет в слова лишние буквы.
    ///
    /// Вася решил помочь Пете. Теперь каждый день Вася диктует Пете слова, а Петя их записывает.
    /// После семестра занятий Петя стал писать много лучше и теперь делает в словах только по одной ошибке.
    /// Чтобы автоматизировать процесс исправления ошибок, Вася просит Вас написать программу, которая удаляет из слова одну лишнюю букву и показывает Пете правильное слово.
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит целое число K - номер лишней буквы, а затем через один или несколько пробелов записано слово S,
	/// состоящее из английских букв верхнего регистра. Гарантируется, что номер буквы от единицы до длины слова включительно. Длина слова не более 80 символов.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите исправленное слово.
    /// </summary>
	public class Task0940
	{
		public static void Main()
		{
			GetInputData(out var k, out var word);

			var result = Solve(k, word);

			PrintResult(result);
		}

		private static void GetInputData(out int k, out string word)
		{
			var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			k = int.Parse(input[0]);
			word = input[1];
		}

		public static string Solve(int k, string word)
		{
			return word.Remove(k - 1, 1);
		}

		private static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
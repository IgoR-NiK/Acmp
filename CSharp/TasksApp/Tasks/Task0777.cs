﻿using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 777 - "Будильник"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Известный исследователь Чарльз Ф. Мантц, устав от долгого путешествия через джунгли, лег спать в 10 часов вечера,
	/// но предварительно он завел будильник на 12 часов следующего дня. Но проспать 14 часов ему не удалось – будильник зазвонил через 2 часа.
	/// Исследователь забыл, что на будильнике, имеющем 12-тичасовой циферблат, можно задать время до звонка только менее 12 часов.
	///
	/// Напишите программу, которая определяет, сколько часов успеет проспать исследователь, прежде чем будильник его разбудит.
	/// 
	/// Входные данные
	/// В единственной строке входного файла INPUT.TXT записаны два целых числа S и T (1 ≤ S, T ≤ 12; S ≠ T),
	/// разделенные одним пробелом - час, когда исследователь лег спать, и час, на который он установил будильник.
	/// 
	/// Выходные данные
	/// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число – через сколько часов зазвонит будильник.
	/// </summary>
	public static class Task0777
    {
        public static void Main()
        {            
            GetInputData(out var s, out var t);

            var result = Solve(s, t);

            PrintResult(result);  
        }

        private static void GetInputData(out int s, out int t)
        {
            var inputData = Console.ReadLine().Split();
            s = int.Parse(inputData[0]);
            t = int.Parse(inputData[1]);
        }

        public static int Solve(int s, int t)
        {
	        var diff = t - s;
	        return diff < 0 ? 12 + diff : diff;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
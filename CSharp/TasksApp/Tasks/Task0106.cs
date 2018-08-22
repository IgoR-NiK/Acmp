using System;
using System.Linq;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 106 - "Монетки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 8%)
    /// 
    /// На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
    /// Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записано натуральное число N (1 ≤ N ≤ 100) – число монеток. 
    /// В каждой из последующих N строк содержится одно целое число – 1 если монетка лежит решкой вверх и 0 если вверх гербом.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите минимальное количество монет, которые нужно перевернуть.
    /// </summary>
    public class Task0106
    {
        public static void Main()
        {
            int[] array;
            GetInputData(out array);

            var result = Solve(array);

            PrintResult(result);
        }

        private static void GetInputData(out int[] array)
        {
            var n = int.Parse(Console.ReadLine());

            array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int Solve(int[] array)
        {
            return Math.Min(array.Count(x => x == 1), array.Count(x => x == 0));
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
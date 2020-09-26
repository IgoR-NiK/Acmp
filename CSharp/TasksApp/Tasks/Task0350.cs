using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 350 - "Перестановки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 44%)
    /// 
    /// Дана строка, состоящая из N попарно различных символов.
    /// Требуется вывести все перестановки символов данной строки.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8),
    /// символы - буквы английского алфавита и цифры.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке.
    /// Перестановки можно выводить в любом порядке.
    /// Повторений и строк, не являющихся перестановками исходной, быть не должно.
    /// </summary>
    public class Task0350
    {
        public static void Main()
        {
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();
        }

        public static string[] Solve(string input)
        {
            if (input.Length == 1)
                return new[] { input };

            var subSolve = Solve(input.Substring(1));
            
            var first = input[0];
            var result = new string[subSolve.Length * input.Length];

            for (var i = 0; i < subSolve.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    result[i * input.Length + j] = subSolve[i].Insert(j, $"{first}");
                }
            }

            return result;
        }

        private static void PrintResult(string[] result)
        {
            foreach(var res in result)            
                Console.WriteLine(res);  
        }
    }
}
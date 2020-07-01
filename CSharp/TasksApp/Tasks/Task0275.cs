using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 275 - "Делимость на 7"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 42%)
    /// 
    /// Требуется определить делимость на 7 ряда целых чисел, записанных в двоичной системе счисления.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT содержится N – количество чисел (N &lt; 50).
    /// В следующих N строках содержатся двоичные числа (по одному в каждой строке). Каждое двоичное число состоит не более чем из 1000 цифр.
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать N строк.
    /// Для каждого теста в отдельной строке надо выдать сообщение “Yes”, если соответствующее число кратно 7 или “No” в противном случае.
    /// </summary>
    public static class Task0275
    {
        public static void Main()
        {
            GetInputData(out var numbers);

            var result = Solve(numbers);

            PrintResult(result);  
        }

        private static void GetInputData(out string[] numbers)
        {
            var n = int.Parse(Console.ReadLine());

            numbers = new string[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
            }
        }

        public static string[] Solve(string[] numbers)
        {
            var result = new string[numbers.Length];

            for (var i = 0; i < numbers.Length; i++)
            {
                var normNumber = numbers[i].PadLeft((int) Math.Ceiling(numbers[i].Length / 3.0) * 3, '0');

                var sum = 0;
                for (var j = 0; j < normNumber.Length / 3; j++)
                {
                    var a = normNumber[j * 3] - '0';
                    var b = normNumber[j * 3 + 1] - '0';
                    var c = normNumber[j * 3 + 2] - '0';

                    sum += a * 4 + b * 2 + c;
                }

                result[i] = sum % 7 == 0 ? "Yes" : "No";
            }

            return result;
        }

        private static void PrintResult(string[] result)
        {
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
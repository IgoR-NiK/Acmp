using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 475 - "Арифметическая прогрессия - 2"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 38%)
    /// 
    /// Задана последовательность натуральных чисел из диапазона [1, 2147483647].
    /// Необходимо определить: можно ли выстроить эти числа в отрезок арифметической прогрессии.
    /// При необходимости порядок чисел в последовательности можно изменять.
    ///
    /// Требуется написать программу для решения этой задачи.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит последовательность натуральных чисел.
    /// Количество чисел в последовательности может быть от 2 до 100 000.
    /// Числа в файле разделены пробелами или символами перехода на новую строку.
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать либо «Yes» в случае положительного ответа, либо «No» в противоположном случае.
    /// </summary>   
    public class Task0475
    {
        public static void Main()
        {
            var numbers = GetInputData();

            var result = Solve(numbers);

            PrintResult(result);
        }

        private static IEnumerable<int> GetInputData()
        {
            while (TryReadInt(out var number))
            {
                yield return number;
            }
        }

        public static bool Solve(IEnumerable<int> numbers)
        {
            var array = new int[100_000];

            var n = 0;
            foreach (var number in numbers)
            {
                array[n] = number;
                n++;
            }
            
            Array.Sort(array, 0, n);

            var d = array[1] - array[0];
            for (var i = 2; i < n; i++)
            {
                if (array[i] - array[i - 1] != d)
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintResult(bool result)
        {
            Console.Write(result ? "Yes" : "No");
        }

        private static bool TryReadInt(out int result)
        {
            result = 0;

            while (true)
            {
                var symbol = Console.Read();

                if (symbol == -1)
                {
                    return result != 0;
                }
                
                if (symbol >= '0' && symbol <= '9')
                {
                    result = result * 10 + (symbol - '0');
                    continue;
                }

                if (result != 0)
                {
                    return true;
                }
            }
        }
    }
}
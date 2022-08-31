using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 23 - "Гадание"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 13%)
    /// 
    /// Как и многие другие девочки, Маша любит разные гадания.
    /// Некоторое время назад Маша узнала новый способ гадать на числах – для какого-нибудь
    /// интересующего ее натурального числа n надо посчитать сумму всех чисел,
    /// на которые n делится без остатка. Маша не очень любит арифметику, и попросила вас написать программу, которая автоматизирует процесс гадания.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записано натуральное число n (n ≤ 1000), которое Маша была вынуждена сообщить.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите сумму всех натуральных делителей числа n.
    /// </summary>
    public class Task0023
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(result);
        }

        private static void GetInputData(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }

        public static int Solve(int n)
        {
            var sum = 0;
            
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }
    }
}
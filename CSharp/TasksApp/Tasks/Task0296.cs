using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 296 - "Лиса Алиса и кот Базилио"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 22%)
    /// 
    /// Лиса Алиса и кот Базилио вырастили денежное дерево. И выросли на нем трехрублевые и пятирублевые золотые монеты.
    /// Лиса Алиса себе взяла трехрублевые монеты, а коту Базилио отдала пятирублевые монеты. Посетовав на свою скромность, она предложила впредь рассчитываться
    /// за покупки вместе, деньги давать без сдачи и минимальным числом монет. Известно, что они сделали покупку стоимостью N рублей, при этом они рассчитались без сдачи.
    ///
    /// Вам следует написать программу, которая определяет: сколько монет внес кот Базилио, и сколько монет внесла лиса Алиса.
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT записано одно натуральное число N – стоимость покупки в рублях (7 &lt; N &lt; 1000).
    /// 
    /// Выходные данные
    /// В выходной OUTPUT.TXT выведите два целых числа через пробел: число монет, которые отдал кот Базилио и число монет, которые отдала лиса Алиса.
    /// </summary>
    public static class Task0296
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

        public static Result Solve(int n)
        {
            switch (n % 5)
            {
                case 0: return new Result(n / 5, 0);
                case 1: return new Result((n - 6) / 5, 2);
                case 2: return new Result((n - 12) / 5, 4);
                case 3: return new Result((n - 3) / 5, 1);
                default: return new Result((n - 9) / 5, 3);
            }
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }
        
        public class Result
        {
            public int Basilio { get; }
            
            public int Alisa { get; }

            public Result(int basilio, int alisa)
            {
                Basilio = basilio;
                Alisa = alisa;
            }

            public override string ToString()
            {
                return $"{Basilio} {Alisa}";
            }
        }
    }
}
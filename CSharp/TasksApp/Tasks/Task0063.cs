using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 63 - "Загадка"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 18%)
    /// 
    /// Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике. 
    /// Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки. 
    /// Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит два натуральных числа S и P, разделенных пробелом.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите два числа Х и Y, загаданные Петей. 
    /// Числа следует вывести в порядке неубывания своих значений, разделенные пробелом.
    /// </summary>
    public static class Task0063 
    {
        public static void Main()
        {
            GetInputData(out var s, out var p);

            var result = Solve(s, p);

            PrintResult(result);  
        }

        private static void GetInputData(out int s, out int p)
        {
            var input = Console.ReadLine().Split();
            s = int.Parse(input[0]);
            p = int.Parse(input[1]);
        }

        public static Result Solve(int s, int p)
        {
            for (var x = 1; x <= 1000; x++)
            {
                for (var y = 1; y <= 1000; y++)
                {
                    if (x * y == p && x + y == s)
                    {
                        return new Result { X = x > y ? y : x, Y = x > y ? x : y };
                    }
                }
            }

            return new Result();
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }

        public struct Result
        {
            public int X;
            public int Y;

            public override string ToString()
            {
                return $"{(X > Y ? Y : X)} {(X > Y ? X : Y)}";
            }
        }
    }
}
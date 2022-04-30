using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 10 - "Уравнение"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 17%)
    /// 
    /// Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем вычисления дискриминанта. 
    /// Но Петя поведал ему о методе решения кубических уравнений вида A*X^3 + B*X^2 + C*X + D = 0. 
    /// На факультативе по математике Васе задали решить около ста уравнений как раз такого вида. 
    /// Но, к сожалению, Вася забыл формулы, о которых рассказывал ему Петя. 
    /// Но Васе было известно, что все корни уравнений – целые числа и находятся на отрезке [-100, 100]. 
    /// Поэтому у Васи есть шанс найти их методом перебора, но для этого ему придется затратить уйму времени, 
    /// т.к. возможно необходимо будет осуществить перебор нескольких тысяч значений. Помогите Васе написать программу, 
    /// которая поможет ему найти корни кубических уравнений!
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записаны 4 числа: A, B, C и D – целые коэффициенты кубического уравнения. 
    /// Каждый коэффициент по модулю меньше 32768.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести через пробел в порядке возрастания 
    /// все корни заданного кубического уравнения. Кратные корни следует выводить только один раз.
    /// </summary>
    public class Task0010
    {
        public static void Main()
        {
            GetInputData(out var a, out var b, out var c, out var d);

            var result = Solve(a, b, c, d);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b, out int c, out int d)
        {
            var input = Console.ReadLine().Split();

            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);
            d = int.Parse(input[3]);
        }

        public static List<int> Solve(int a, int b, int c, int d)
        {
            var roots = new List<int>();

            for (var i = -100; i < 101; i++)
            {
                if (Math.Abs(a * Math.Pow(i, 3) + b * Math.Pow(i, 2) + c * i + d) <= 10e-7)
                {
                    roots.Add(i);
                }
            }

            return roots;
        }

        private static void PrintResult(List<int> result)
        {
            result.ForEach(x => Console.Write($"{x} "));
        }
    }
}
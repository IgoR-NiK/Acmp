using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 102 - "Треугольник и точка"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 32%)
    /// 
    /// В декартовой системе координат на плоскости заданы координаты вершин треугольника и еще одной точки. 
    /// Требуется написать программу, определяющую, принадлежит ли эта точка треугольнику.
    /// 
    /// Входные данные
    /// В четырех строках входного файла INPUT.TXT находятся пары целых чисел - координаты точек. 
    /// Числа в первых трех строках - это координаты вершин треугольника (x1,y1), (x2,y2), (х3,у3), 
    /// в четвертой строке - координаты тестируемой точки (x4,у4). Все координаты не превышают 10000 по абсолютной величине.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT необходимо вывести слово «In», если точка находится внутри треугольника и «Out» в противном случае.
    /// </summary>
    public static class Task0102
    {
        public static void Main()
        {
            GetInputData(out var points);

            var result = Solve(points);

            PrintResult(result);  
        }

        private static void GetInputData(out Point[] points)
        {
            const int countPoints = 4;
            points = new Point[countPoints];
            for (var i = 0; i < countPoints; i++)
            {
                var input = Console.ReadLine().Split();
                points[i] = new Point { X = int.Parse(input[0]), Y = int.Parse(input[1]) };
            }
        }

        public static string Solve(Point[] points)
        {
            var s1 = GetArea(points[0], points[1], points[2]);
            var s2 = GetArea(points[0], points[1], points[3]);
            var s3 = GetArea(points[0], points[2], points[3]);
            var s4 = GetArea(points[1], points[2], points[3]);

            return Math.Abs(s1 - (s2 + s3 + s4)) < 0.00000000001 ? "In" : "Out";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        private static double GetArea(Point a, Point b, Point c)
        {
            var line1 = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            var line2 = Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2));
            var line3 = Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2));
            var p = (line1 + line2 + line3) / 2;
            return Math.Round(Math.Sqrt(p * (p - line1) * (p - line2) * (p - line3)), 3);
        }

        public struct Point
        {
            public int X;
            public int Y;
        }
    }
}
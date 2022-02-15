using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 28 - "Симметрия"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 19%)
    /// 
    /// Многие из вас, вероятно, знакомы с понятием симметрии относительно прямой. 
    /// Пусть на плоскости расположена прямая L и точка A. 
    /// Точка B называется симметричной точке A относительно прямой L, если отрезок АВ перпендикулярен прямой L и 
    /// делится пополам точкой пересечения с ней. В частности, если точка А лежит на прямой L, то точка B совпадает с точкой А.
    /// 
    /// Задана прямая L, параллельная одной из осей координат, и точка А.Найдите точку В, симметричную А относительно L.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит 4 числа: x1, y1, x2, y2 – координаты двух различных точек, 
    /// через которые проходит прямая L. Вторая строка входного файла содержит 2 числа xA и yA – координаты точки А. 
    /// Все числа во входном файле целые и не превосходят 10^8 по модулю.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите числа xB и yB – координаты точки B.
    /// </summary>
    public class Task0028
    {
        public static void Main()
        {
            GetInputData(out var line, out var a);

            var b = Solve(line, a);

            PrintResult(b);
        }

        private static void GetInputData(out Line line, out Point a)
        {
            var input = Console.ReadLine().Split();

            line = new Line(
                new Point(int.Parse(input[0]), int.Parse(input[1])), 
                new Point(int.Parse(input[2]), int.Parse(input[3])));

            input = Console.ReadLine().Split();

            a = new Point(int.Parse(input[0]), int.Parse(input[1]));
        }

        public static Point Solve(Line line, Point a)
        {
            return line.Point1.X == line.Point2.X 
                ? new Point(2 * line.Point1.X - a.X, a.Y) 
                : new Point(a.X, 2 * line.Point1.Y - a.Y);
        }

        private static void PrintResult(Point result)
        {
            Console.Write(result);
        }

        public struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"{X} {Y}";
            }
        }

        public struct Line
        {
            public Point Point1;
            public Point Point2;

            public Line(Point point1, Point point2)
            {
                Point1 = point1;
                Point2 = point2;
            }
        }
    }    
}
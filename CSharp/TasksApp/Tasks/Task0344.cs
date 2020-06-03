using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 344 - "Ближайшие точки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 38%)
    /// 
    /// Антон в школе начал изучать математику. Его внимание привлекло новое для него понятие числовой прямой.
    /// Антон быстро научился вычислять расстояния между двумя точками на этой прямой, задавать отрезки и интервалы на ней.
    ///
    /// Готовясь к контрольной работе, Антон столкнулся со следующей задачей: «На числовой прямой задано n точек.
    /// Необходимо найти среди них две ближайшие». Расстояние между двумя точками числовой прямой x и y равно |x - y|.
    ///
    /// Требуется написать программу, которая поможет Антону решить поставленную задачу.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит количество точек n (2 ≤ n ≤ 10^5).
    /// Вторая строка содержит n различных целых чисел x(i) – координаты заданных точек числовой прямой.
    /// Числа в строке разделены пробелом. Значения всех координат x(i) не превосходят 10^9 по абсолютной величине.
    /// 
    /// Выходные данные
    /// В первой строке выходного файла OUTPUT.TXT необходимо вывести минимальное расстояние между двумя точками,
    /// заданными во входном файле. Во второй строке выходного файла необходимо вывести номера точек,
    /// которым соответствует найденное расстояние. Точки нумеруются натуральными числами от 1 до n в том порядке,
    /// в котором они заданы во входном файле. Если ответов несколько, выведите тот из них,
    /// в котором точки расположены левее других на числовой прямой.
    /// Первым выводится номер левой точки, далее через пробел – номер правой точки.
    /// </summary>
    public class Task0344
    {
        public static void Main()
        {
            GetInputData(out var points);

            var result = Solve(points);

            PrintResult(result);
        }

        private static void GetInputData(out Point[] points)
        {
            var n = int.Parse(Console.ReadLine());
            var coordinates = Console.ReadLine().Split();

            points = new Point[n];
            for (var i = 0; i < n; i++)
            {
                points[i] = new Point(i + 1, int.Parse(coordinates[i]));
            }
        }

        public static Result Solve(Point[] points)
        {
            var result = new Result();

            Array.Sort(points, new PointComparer());

            var min = int.MaxValue;
            for (var i = 0; i < points.Length - 1; i++)
            {
                var distance = points[i + 1].Coordinate - points[i].Coordinate;
                if (distance < min)
                {
                    min = distance;
                    result.Point1 = points[i];
                    result.Point2 = points[i + 1];
                }

                if (min == 1)
                {
                    break;
                }
            }
            
            return result;
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result.Distance);
            Console.WriteLine($"{result.Point1} {result.Point2}");
        }

        public struct Point
        {
            public int Number { get; }
            
            public int Coordinate { get; }

            public Point(int number, int coordinate)
            {
                Number = number;
                Coordinate = coordinate;
            }

            public override string ToString() => $"{Number}";
        }
        
        public class Result
        {
            public Point Point1 { get; set; }
            
            public Point Point2 { get; set; }

            public int Distance => Math.Abs(Point2.Coordinate - Point1.Coordinate);
        }
        
        private class PointComparer : IComparer<Point>
        {
            public int Compare(Point x, Point y)
            {
                return x.Coordinate.CompareTo(y.Coordinate);
            }
        }
    }
}
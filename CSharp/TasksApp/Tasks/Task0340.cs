using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 340 - "Коробки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 19%)
    /// 
    /// На столе лежат коробка размера A1 × B1 × C1 и коробка размера A2 × B2 × C2. 
    /// Выясните можно ли одну из этих коробок положить в другую, если разрешены повороты коробок вокруг любого ребра на угол 90 градусов.
    ///    
    /// Входные данные
    /// Первая строка входного файла содержит три целых числа A1, B1 и C1. 
    /// Вторая строка входного файла содержит три целых числа A2, B2 и C2. 
    /// Все числа положительны и не превосходят 1000.
    /// 
    /// Выходные данные
    /// Если коробки одинаковы, выведите "Boxes are equal". 
    /// Если первая коробка может быть положена во вторую, выведите "The first box is smaller than the second one". 
    /// Если вторая коробка может быть положена в первую, выведите "The first box is larger than the second one". 
    /// Иначе, выведите "Boxes are incomparable".
    /// </summary>
    public class Task0340
    {
        public static void Main()
        {
            GetInputData(out var box1, out var box2);

            var result = Solve(box1, box2);

            PrintResult(result);
        }

        private static void GetInputData(out Box box1, out Box box2)
        {
            box1 = ReadBox();
            box2 = ReadBox();

            Box ReadBox()
            {
                var input = Console.ReadLine().Split();
                return new Box(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
            }
        }

        public static string Solve(Box box1, Box box2)
        {
            var orderedSidesBox1 = box1.GetOrderedSides();
            var orderedSidesBox2 = box2.GetOrderedSides();

            if (orderedSidesBox1[0] == orderedSidesBox2[0] 
                && orderedSidesBox1[1] == orderedSidesBox2[1] 
                && orderedSidesBox1[2] == orderedSidesBox2[2])
            {
                return "Boxes are equal";
            }
            else if(orderedSidesBox1[0] <= orderedSidesBox2[0]
                && orderedSidesBox1[1] <= orderedSidesBox2[1]
                && orderedSidesBox1[2] <= orderedSidesBox2[2])
            {
                return "The first box is smaller than the second one";
            }
            else if (orderedSidesBox1[0] >= orderedSidesBox2[0]
                && orderedSidesBox1[1] >= orderedSidesBox2[1]
                && orderedSidesBox1[2] >= orderedSidesBox2[2])
            {
                return "The first box is larger than the second one";
            }
            else
            {
                return "Boxes are incomparable";
            }
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        public struct Box
        {
            public int A;
            public int B;
            public int C;

            public Box(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }
            
            public int[] GetOrderedSides()
            {
                var sides = new[] { A, B, C };

                Array.Sort(sides);

                return sides;
            } 
        }
    }
}
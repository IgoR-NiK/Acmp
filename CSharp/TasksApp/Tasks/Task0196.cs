using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 196 - "Спираль"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 38%)
    /// 
    /// Требуется вывести квадрат, состоящий из N×N клеток, заполненных числами от 1 до N^2 по спирали (см. примеры).
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT задано целое число N – размер квадратной матрицы (2 ≤ N ≤ 100).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите матрицу, заполненную числами от 1 до N^2 по спирали, 
    /// при этом между числами может быть любое количество пробелов. Не допускается начинать спираль в ином, 
    /// кроме верхнего левого, углу, закручивать спираль против часовой стрелки или изнутри наружу.
    /// </summary>
    public static class Task0196 
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

        public static int[][] Solve(int n)
        {
            var result = new int[n][];
            for (var i = 0; i < n; i++)
                result[i] = new int[n];

            var direction = Direction.Right;
            for (int p = 1, i = 0, j = 0; p <= n * n;)
            {
                result[i][j] = p;
                p++;

                switch (direction)
                {
                    case Direction.Up:
                        if (i - 1 >= 0 && result[i - 1][j] == 0)
                        {
                            i--;
                        }
                        else
                        {
                            j++;
                            direction = Direction.Right;
                        }
                        break;
                    case Direction.Right:
                        if (j + 1 < n && result[i][j + 1] == 0)
                        {
                            j++;
                        }
                        else
                        {
                            i++;
                            direction = Direction.Down;
                        }
                        break;
                    case Direction.Down:
                        if (i + 1 < n && result[i + 1][j] == 0)
                        {
                            i++;
                        }
                        else
                        {
                            j--;
                            direction = Direction.Left;
                        }
                        break;
                    case Direction.Left:
                        if (j - 1 >= 0 && result[i][j - 1] == 0)
                        {
                            j--;
                        }
                        else
                        {
                            i--;
                            direction = Direction.Up;
                        }
                        break;
                }
            }

            return result;
        }

        private static void PrintResult(int[][] result)
        {
            foreach (var rows in result)
            {
                foreach (var column in rows)
                {
                    Console.WriteLine($"{column} ");
                }
                Console.WriteLine();
            }
        }

        enum Direction
        {
            Up,
            Right,
            Down,
            Left
        }
    }
}
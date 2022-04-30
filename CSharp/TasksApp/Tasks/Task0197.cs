using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 197 - "Змейка"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 40%)
    /// 
    /// Требуется заполнить змейкой квадратную матрицу так, как показано на рисунке справа:
    /// заполнение происходит с единицы из левого верхнего угла и заканчивается в правом нижнем числом N^2,
    /// где N – порядок матрицы.
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT задано натуральное число N – размер квадратной матрицы (N ≤ 100).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите матрицу, заполненную числами от 1 до N^2 змейкой,
    /// при этом между числами может быть любое количество пробелов.
    /// </summary>
    public static class Task0197 
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

            var direction = Direction.DownLeft;
            for (int p = 1, i = 0, j = 0; p <= n * n; p++)
            {
                result[i][j] = p;

                switch (direction)
                {
                    case Direction.DownLeft:
                        if (i + 1 >= n)
                        {
                            j++;
                            direction = Direction.UpRight;
                        }
                        else if (j - 1 < 0)
                        {
                            i++;
                            direction = Direction.UpRight;
                        }
                        else
                        {
                            j--;
                            i++;
                        }

                        break;
                    case Direction.UpRight:
                        if (j + 1 >= n)
                        {
                            i++;
                            direction = Direction.DownLeft;
                        } 
                        else if (i - 1 < 0)
                        {
                            j++;
                            direction = Direction.DownLeft;
                        }
                        else
                        {
                            i--;
                            j++;
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

        private enum Direction
        {
            DownLeft,
            UpRight
        }
    }
}
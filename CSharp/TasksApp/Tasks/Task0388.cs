using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 388 - "Седловые точки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 28%)
    /// 
    /// Задана матрица, содержащая N строк и M столбцов. Седловой точкой этой матрицы назовем элемент,
    /// который одновременно является минимумом в своей строке и максимумом в своем столбце.
    ///
    /// Найдите количество седловых точек заданной матрицы.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT в первой строке содержит целые числа N и M (1 ≤ N, M ≤ 750).
    /// Далее следуют N строк по M чисел в каждой. Элементы матрицы - целые числа,
    /// не превосходящие 1000 по абсолютной величине. Числа могут быть разделены несколькими пробелами.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите ответ на задачу.
    /// </summary>
    public class Task0388
    {
        public static void Main()
        {
            GetInputData(out var field);

            var result = Solve(field);

            PrintResult(result);
        }

        private static void GetInputData(out int[,] field)
        {
            var input = Console.ReadLine().Split();
            
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            
            field = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (var j = 0; j < m; j++)
                {
                    field[i, j] = int.Parse(input[j]);
                }
            }
        }

        public static int Solve(int[,] field)
        {
            var n = field.GetLength(0);
            var m = field.GetLength(1);

            var mins = new int[n];
            for (var i = 0; i < n; i++)
            {
                mins[i] = field[i, 0];
                for (var j = 1; j < m; j++)
                {
                    if (field[i, j] < mins[i])
                        mins[i] = field[i, j];
                }
            }

            var result = 0;
            
            for (var j = 0; j < m; j++)
            {
                var max = field[0, j];
                for (var i = 1; i < n; i++)
                {
                    if (field[i, j] > max)
                        max = field[i, j];
                }

                for (var i = 0; i < n; i++)
                {
                    if (max == mins[i])
                        result++;
                }
            }

            return result;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
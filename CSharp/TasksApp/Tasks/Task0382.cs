using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 382 - "Покраска лабиринта"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 46%)
    /// 
    /// Лабиринт представляет собой квадрат, состоящий из N×N сегментов. Каждый из сегментов может быть либо пустым,
    /// либо заполненным монолитной каменной стеной. Гарантируется, что левый верхний и правый нижний сегменты пусты.
    /// Лабиринт обнесён сверху, снизу, слева и справа стенами, оставляющими свободными только левый верхний и правый
    /// нижний углы. Директор лабиринта решил покрасить стены лабиринта, видимые изнутри (см. рисунок).
    /// Помогите ему рассчитать количество краски, необходимой для этого.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT находится число N, затем идут N строк по N символов:
    /// точка обозначает пустой сегмент, решётка - сегмент со стеной. Размер сегментов – 5х5 метров,
    /// высота стен – 5 метров. (3 ≤ N ≤ 50)
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите одно число - площадь видимой части
    /// внутренних стен лабиринта в квадратных метрах.
    /// </summary>
    public class Task0382
    {
        public static void Main()
        {
            GetInputData(out var field);

            var result = Solve(field);

            PrintResult(result);
        }

        private static void GetInputData(out int[,] field)
        {
            var n = int.Parse(Console.ReadLine());
            field = new int[n, n];
            
            for (var i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                for (var j = 0; j < n; j++)
                {
                    switch (str[j])
                    {
                        case '.': field[i, j] = 0; break;
                        case '#': field[i, j] = 2; break;
                    }
                }
            }
        }

        public static long Solve(int[,] field)
        {
            var n = field.GetLength(0);
            
            var count = 
                Count(field, 0, 0) + 
                Count(field, n - 1, n - 1);

            return (count - 4) * 25;
        }

        private static void PrintResult(long result)
        {
            Console.WriteLine(result);
        }
        
        private static long Count(int[,] field, int curI, int curJ)
        {
            var count = 0L;
            if (field[curI, curJ] != 1)
            {
                field[curI, curJ] = 1;
                count += Calculate(field, curI, curJ);
                if (curJ + 1 < field.GetLength(1) && field[curI, curJ + 1] == 0)
                {
                    count += Count(field, curI, curJ + 1);
                }
                if (curJ - 1 >= 0 && field[curI, curJ - 1] == 0)
                {
                    count += Count(field, curI, curJ - 1);
                }
                if (curI - 1 >= 0 && field[curI - 1, curJ] == 0)
                {
                    count += Count(field, curI - 1, curJ);
                }
                if (curI + 1 < field.GetLength(0) && field[curI + 1, curJ] == 0)
                {
                    count += Count(field, curI + 1, curJ);
                }
            }           
 
            return count;
        }
 
        private static long Calculate(int[,] field, int curI, int curJ)
        {
            var count = 0L;
            if (curJ + 1 < field.GetLength(1))
            {
                if (field[curI, curJ + 1] == 2) count++;
            }
            else
            {
                count++;
            }
 
            if (curJ - 1 >= 0)
            {
                if (field[curI, curJ - 1] == 2) count++;
            }
            else
            {
                count++;
            }
 
            if (curI + 1 < field.GetLength(0))
            {
                if (field[curI + 1, curJ] == 2) count++;
            }
            else
            {
                count++;
            }
 
            if (curI - 1 >= 0)
            {
                if (field[curI - 1, curJ] == 2) count++;
            }
            else
            {
                count++;
            }
 
            return count;
        }
    }
}
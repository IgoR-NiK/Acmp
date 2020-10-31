using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 431 - "Путь коня"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 44%)
    /// 
    /// Дана шахматная доска, состоящая из N×N клеток, несколько из них вырезано.
    /// Провести ходом коня через невырезанные клетки путь минимальной длины из одной заданной клетки в другую.
    ///
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT задано число N (2 ≤ N ≤ 50). В следующих N строках содержится по N символов.
    /// Символом # обозначена вырезанная клетка, точкой - невырезанная клетка, @ - заданные клетки (таких символов два), соответствующие началу и концу пути коня.
    /// 
    /// Выходные данные
    /// Если путь построить невозможно, в выходной файл OUTPUT.TXT следует вывести "Impossible",
    /// в противном случае вывести такую же карту, как и на входе, но пометить все промежуточные положения коня символом @.
    /// </summary>
    public class Task0431
    {
        public static void Main()
        {
            GetInputData(out var field);

            var result = Solve(field);

            PrintResult(result);
        }

        private static void GetInputData(out int[,] field)
        {
            var input = Console.ReadLine();
            var n = int.Parse(input.Split()[0]);

            field = new int[n, n];
            for (var i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                for (var j = 0; j < n; j++)
                {
                    field[i, j] = Convert(input[j]);
                }               
            }
        }

        public static Result Solve(int[,] field)
        {
            var n = field.GetLength(0);
            
            //Ищем старт
            var startI = 0;
            var startJ = 0;
            
            var isBreak = false;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (field[i, j] == -2)
                    {
                        startI = i;
                        startJ = j;
                        field[i, j] = -3;
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak) break;
            }
            
            //Ищем финиш
            var finishI = 0;
            var finishJ = 0;
            
            isBreak = false;
            for (var i = n - 1; i >= 0; i--)
            {
                for (var j = n - 1; j >= 0; j--)
                {
                    if (field[i, j] == -2)
                    {
                        finishI = i;
                        finishJ = j;
                        field[i, j] = -3;
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak) break;
            }
            
            // Помечаем стартовую ячейку 0
            var d = 0;
            field[startI, startJ] = 0;
            
            // Распространение волны
            var isWavePropagation = false;
            do
            {
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        if (field[i, j] == d)
                        {
                            if (i - 2 >= 0 && j - 1 >= 0 && field[i - 2, j - 1] == -3) { field[i - 2, j - 1] = d + 1; isWavePropagation = true; }
                            if (i - 2 >= 0 && j + 1 < n && field[i - 2, j + 1] == -3) { field[i - 2, j + 1] = d + 1; isWavePropagation = true; }
                            if (i - 1 >= 0 && j + 2 < n && field[i - 1, j + 2] == -3) { field[i - 1, j + 2] = d + 1; isWavePropagation = true; }
                            if (i + 1 < n && j + 2 < n && field[i + 1, j + 2] == -3) { field[i + 1 , j + 2] = d + 1; isWavePropagation = true; }
                            if (i + 2 < n && j + 1 < n && field[i + 2, j + 1] == -3) { field[i + 2, j + 1] = d + 1; isWavePropagation = true; }
                            if (i + 2 < n && j - 1 >= 0 && field[i + 2, j - 1] == -3) { field[i + 2, j - 1] = d + 1; isWavePropagation = true; }
                            if (i + 1 < n && j - 2 >= 0 && field[i + 1, j - 2] == -3) { field[i + 1, j - 2] = d + 1; isWavePropagation = true; }
                            if (i - 1 >= 0 && j - 2 >= 0 && field[i - 1, j - 2] == -3) { field[i - 1, j - 2] = d + 1; isWavePropagation = true; }
                        }
                    }
                }
                d++;
            } while (field[finishI, finishJ] == -3 && isWavePropagation);
            
            // Восстановление пути
            if (field[finishI, finishJ] != -3)
            {
                var curI = finishI;
                var curJ = finishJ;
                var temp = field[curI, curJ];
                field[curI, curJ] = -2;             
                do
                {
                    if (curI - 2 >= 0 && curJ - 1 >= 0 && field[curI - 2, curJ - 1] == temp - 1) { curI -= 2; curJ -= 1; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI - 2 >= 0 && curJ + 1 < n && field[curI - 2, curJ + 1] == temp - 1) { curI -= 2; curJ += 1; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI - 1 >= 0 && curJ + 2 < n && field[curI - 1, curJ + 2] == temp - 1) { curI -= 1; curJ += 2; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI + 1 < n && curJ + 2 < n && field[curI + 1, curJ + 2] == temp - 1) { curI += 1; curJ += 2; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI + 2 < n && curJ + 1 < n && field[curI + 2, curJ + 1] == temp - 1) { curI += 2; curJ += 1; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI + 2 < n && curJ - 1 >= 0 && field[curI + 2, curJ - 1] == temp - 1) { curI += 2; curJ -= 1; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI + 1 < n && curJ - 2 >= 0 && field[curI + 1, curJ - 2] == temp - 1) { curI += 1; curJ -= 2; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                    else if (curI - 1 >= 0 && curJ - 2 >= 0 && field[curI - 1, curJ - 2] == temp - 1) { curI -= 1; curJ -= 2; temp = field[curI, curJ]; field[curI, curJ] = -2; }
                } while (!(curI == startI && curJ == startJ));
            }
            else
            {
                return new Result { IsSuccess = false };
            }
            
            // Рисуем поле снова
            var result = new Result { IsSuccess = true, Field = new int[n, n] };
            
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (field[i, j] > 0)
                    {
                        field[i, j] = -3;
                    }

                    result.Field[i, j] = field[i, j];
                }
            }

            return result;
        }

        private static void PrintResult(Result result)
        {
            if (result.IsSuccess)
            {
                for (var i = 0; i < result.Field.GetLength(0); i++)
                {
                    for (var j = 0; j < result.Field.GetLength(1); j++)
                    {
                        Console.Write(Convert(result.Field[i, j]));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }

        public class Result
        {
            public bool IsSuccess { get; set; }
            
            public int[,] Field { get; set; }
        }

        private static char Convert(int number)
        {
            switch (number)
            {
                case -3: return '.';
                case -2: return '@';
                case -1: return '#';
                default: return ' ';
            }
        }
        
        private static int Convert(char symbol)
        {
            switch (symbol)
            {
                case '.': return -3;
                case '@': return -2;
                case '#': return -1;
                default: return 0;
            }
        }
    }
}
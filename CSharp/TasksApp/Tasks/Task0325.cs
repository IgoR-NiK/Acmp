using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 325 - "Мы с конем вдвоем по полю пойдем"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 31%)
    /// 
    /// Заданы две клетки шахматной доски. Требуется определить, возможно ли попасть из одной клетки в другую одним ходом шахматного коня, 
    /// а если нет, то следует выяснить, возможно ли попасть с помощью двух ходов.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит координаты двух клеток в общепринятом формате: каждая координата записывается 
    /// как английская строчная буква и цифра, координаты отделены друг от друга запятой и пробелом. 
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать цифру «1», если возможно из одной клетки в другую попасть за 1 ход, 
    /// либо цифру «2», если попасть можно за 2 хода, либо «NO», если одна клетка недостижима из другой ни за 1 ни за 2 хода.
    /// </summary>
    public class Task0325
    {
        public static void Main()
        {
            GetInputData(out var sourceCell, out var terminalCell);

            var result = Solve(sourceCell, terminalCell);

            PrintResult(result);
        }

        private static void GetInputData(out string sourceCell, out string terminalCell)
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            sourceCell = input[0];
            terminalCell = input[1];
        }

        public static string Solve(string sourceCell, string terminalCell)
        {
            // Находим клетки после первого хода
            var firstMoves = GetAvailableMovesFrom(sourceCell);

            // Находим клетки после второго хода
            var secondMoves = new List<string>();
            firstMoves.ForEach((firstMove) => secondMoves.AddRange(GetAvailableMovesFrom(firstMove)));

            return firstMoves.Contains(terminalCell) ? "1" : secondMoves.Contains(terminalCell) ? "2" : "NO";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        private static List<string> GetAvailableMovesFrom(string cell)
        {
            var availableMoves = new List<string>();

            var row = cell[1] - '1';
            var column = cell[0] - 'a';

            if (column + 1 < 8 && row - 2 >= 0)
                availableMoves.Add(GetCoordinate(column + 1, row - 2));
            if (column + 2 < 8 && row - 1 >= 0)
                availableMoves.Add(GetCoordinate(column + 2, row - 1));
            if (column + 2 < 8 && row + 1 < 8)
                availableMoves.Add(GetCoordinate(column + 2, row + 1));
            if (column + 1 < 8 && row + 2 < 8)
                availableMoves.Add(GetCoordinate(column + 1, row + 2));
            if (column - 1 >= 0 && row + 2 < 8)
                availableMoves.Add(GetCoordinate(column - 1, row + 2));
            if (column - 2 >= 0 && row + 1 < 8)
                availableMoves.Add(GetCoordinate(column - 2, row + 1));
            if (column - 2 >= 0 && row - 1 >= 0)
                availableMoves.Add(GetCoordinate(column - 2, row - 1));
            if (column - 1 >= 0 && row - 2 >= 0)
                availableMoves.Add(GetCoordinate(column - 1, row - 2));

            return availableMoves;
        }

        private static string GetCoordinate(int column, int row)
        {
            return $"{(char)('a' + column)}{(char)('1' + row)}";
        }
    }
}
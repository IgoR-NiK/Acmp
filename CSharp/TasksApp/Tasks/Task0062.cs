using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 62 - "Клетки"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
    /// 
    /// Известно, что шахматная доска имеет размерность 8х8 и состоит из клеток 2х цветов, например, черного и белого (см. рисунок). 
    /// Каждая клетка имеет координату, состоящую из буквы и цифры. Горизонтальное расположение клетки определяется буквой от A до H, 
    /// а вертикальное – цифрой от 1 до 8. Заметим, что клетка с координатой А1 имеет черный цвет. Требуется по заданной координате определить цвет клетки.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записана координата клетки на шахматной доске: всего два символа – буква и цифра (без пробелов).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно вывести «WHITE», если указанная клетка имеет белый цвет и «BLACK», если она черная.
    /// </summary>
    public static class Task0062 
    {
        public static void Main()
        {
            string input;
            GetInputData(out input);

            var result = Solve(input);

            PrintResult(result);  
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();          
        }

        public static string Solve(string input)
        {
            int X = input[0] - 'A' + 1;
            int Y = Convert.ToInt32(input[1]);
            
            return (X + Y) % 2 == 0 ? "BLACK" : "WHITE";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
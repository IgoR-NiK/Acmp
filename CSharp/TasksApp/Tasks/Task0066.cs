using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 66 - "Клавиатура"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 11%)
    /// 
    /// Для данной буквы английского алфавита нужно вывести справа стоящую букву на стандартной клавиатуре.
    /// При этом клавиатура замкнута, т.е. справа от буквы «p» стоит буква «a», от буквы «l» стоит буква «z», а от буквы «m» — буква «q».
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит один символ — маленькую букву английского алфавита.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT следует вывести букву стоящую справа от заданной буквы, с учетом замкнутости клавиатуры.
    /// </summary>
    public static class Task0066 
    {
        public static void Main()
        {
            GetInputData(out var symbol);

            var result = Solve(symbol);

            PrintResult(result);  
        }

        private static void GetInputData(out char symbol)
        {
            symbol = (char)Console.Read();
        }

        public static char Solve(char symbol)
        {
            switch (symbol)
            {
                case 'q': return 'w';
                case 'w': return 'e';
                case 'e': return 'r';
                case 'r': return 't';
                case 't': return 'y';
                case 'y': return 'u';
                case 'u': return 'i';
                case 'i': return 'o';
                case 'o': return 'p';
                case 'p': return 'a';
                case 'a': return 's';
                case 's': return 'd';
                case 'd': return 'f';
                case 'f': return 'g';
                case 'g': return 'h';
                case 'h': return 'j';
                case 'j': return 'k';
                case 'k': return 'l';
                case 'l': return 'z';
                case 'z': return 'x';
                case 'x': return 'c';
                case 'c': return 'v';
                case 'v': return 'b';
                case 'b': return 'n';
                case 'n': return 'm';
                default: return 'q';
            }
        }

        private static void PrintResult(char result)
        {
            Console.WriteLine(result);
        }
    }
}
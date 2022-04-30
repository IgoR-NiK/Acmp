using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 6 - "Шахматы"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 23%)
    /// 
    /// Совсем недавно Вася занялся программированием и решил реализовать собственную программу для игры в шахматы. 
    /// Но у него возникла проблема определения правильности хода конем, который делает пользователь. 
    /// Т.е. если пользователь вводит значение «C7-D5», то программа должна определить это как правильный ход, если же введено «E2-E4», 
    /// то ход неверный. Так же нужно проверить корректность записи ввода: если например, введено «D9-N5», то программа должна определить 
    /// данную запись как ошибочную. Помогите ему осуществить эту проверку! 
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записан текст хода (непустая строка), 
    /// который указал пользователь. Пользователь не может ввести строку, длиннее 5 символов. 
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно вывести «YES», если указанный ход конем верный, если же запись корректна 
    /// (в смысле правильности записи координат), но ход невозможен, то нужно вывести «NO». 
    /// Если же координаты не определены или заданы некорректно, то вывести сообщение «ERROR». 
    /// </summary>
    public class Task0006
    {
        public static void Main()
        {
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();
        }

        public static string Solve(string str)
        {
            if (str.Length == 5 && IsLetter(str[0]) && IsDigit(str[1]) && IsDash(str[2]) && IsLetter(str[3]) && IsDigit(str[4]))
                if (Math.Abs(str[0] - str[3]) > 2 || Math.Abs(str[1] - str[4]) > 2)
                    return "NO";
                else if (Math.Abs(str[0] - str[3]) + Math.Abs(str[1] - str[4]) == 3)
                    return "YES";
                else
                    return "NO";
            return "ERROR";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        private static bool IsLetter(char symbol)
        {
            return symbol >= 'A' && symbol <= 'H';
        }

        private static bool IsDigit(char symbol)
        {
            return symbol >= '1' && symbol <= '8';
        }

        private static bool IsDash(char symbol)
        {
            return symbol == '-';
        }        
    }
}
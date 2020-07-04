using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 277 - "Школьная алгебра"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 27%)
    /// 
    /// Трёхчлен a + bx + сy от двух переменных x и y однозначно определяется коэффициентами a, b и c.
    /// Написать программу, которая по заданным a, b и c выводит соответствующий трёхчлен, записанный с использованием алгебраических соглашений:
    ///
    /// - коэффициент при члене, содержащем переменную, опускается, если его модуль равен единице;
    /// - член, коэффициент при котором равен нулю, опускается (кроме случая, когда все коэффициенты равны нулю, тогда трехчлен состоит из одной цифры 0);
    /// - знак "+" опускается, если он предшествует отрицательному коэффициенту;
    /// - знак "+" опускается, если он стоит в начале выражения (так называемый унарный плюс);
    /// - знак умножения между коэффициентом и переменной опускается.
    ///
    /// При этом запрещено менять местами члены.
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT через пробел записаны целые коэффициенты a, b и с, каждое из которых не превосходит 30000 по абсолютной величине.
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать трехчлен, записанный с использованием алгебраических соглашений.
    /// </summary>
    public static class Task0277
    {
        public static void Main()
        {
            GetInputData(out var a, out var b, out var c);

            var result = Solve(a, b, c);

            PrintResult(result);  
        }

        private static void GetInputData(out int a, out int b, out int c)
        {
            var input = Console.ReadLine().Split();
            
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);
        }

        public static string Solve(int a, int b, int c)
        {
            var result = "";
             
            if (a == 0 && b == 0 && c == 0)
            {
                result = "0";
            }
            else
            {
                if (a != 0)
                {
                    result += $"{a}";
                }

                result += PrintPart(b, "x");
                result += PrintPart(c, "y");

                result = result.TrimStart('+');
            }
            
            return result;
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
        
        private static string PrintPart(int num, string variable)
        {
            if (num == 0)
            {
                return "";
            }
                    
            if (num < 0)
            {
                return num == -1 ? $"-{variable}" : $"{num}{variable}";
            }

            return num == 1 ? $"+{variable}" : $"+{num}{variable}";
        }
    }
}
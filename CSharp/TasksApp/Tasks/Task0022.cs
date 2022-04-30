using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 22 - "Единицы"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 16%)
    /// 
    /// На уроках информатики вас, наверное, учили переводить числа из одних систем счисления в другие и выполнять другие подобные операции. 
    /// Пришло время продемонстрировать эти знания. Найдите количество единиц в двоичной записи заданного числа.
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT записано целое число n (0 ≤ n ≤ 2*10^9).
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — количество двоичных единиц в записи числа n.
    /// </summary>
    public class Task0022
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

        public static int Solve(int n)
        {
            var s = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    s++;
                }
                n /= 2;
            }
            return s;
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }
    }
}
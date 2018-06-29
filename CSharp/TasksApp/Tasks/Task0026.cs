using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 26 - "Две окружности"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 17%)
    /// 
    /// На плоскости даны две окружности. Требуется проверить, пересекаются ли они.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT состоит из двух строк. На каждой строке записана информация об одной окружности – 
    /// координаты ее центра x и y (целые числа, по модулю не превосходящие 5000) и радиус (целое число 1 ≤ r ≤ 1000).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите «YES», если окружности пересекаются, и «NO» в противном случае.
    /// </summary>
    public class Task0026
    {
        public static void Main()
        {
            int x1, y1, r1;
            int x2, y2, r2;
            GetInputData(out x1, out y1, out r1);
            GetInputData(out x2, out y2, out r2);

            var result = Solve(x1, y1, r1, x2, y2, r2);

            PrintResult(result);
        }

        private static void GetInputData(out int x, out int y, out int r)
        {
            var input = Console.ReadLine().Split();

            x = int.Parse(input[0]);
            y = int.Parse(input[1]);
            r = int.Parse(input[2]);
        }

        public static string Solve(int x1, int y1, int r1, int x2, int y2, int r2)
        {
            var d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return d < Math.Abs(r2 - r1) || d > r1 + r2 ? "NO" : "YES";
        }

        private static void PrintResult(string result)
        {
            Console.Write(result);
        }
    }
}
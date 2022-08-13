using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 394 - "Апельсины"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 26%)
    /// 
    /// Катя решила пригласить к себе в гости n друзей. Так как ее друзья очень любят фрукты, то в качестве угощения для них она купила m одинаковых апельсинов.
    ///
    /// Она хочет разрезать каждый апельсин на одинаковое число равных долек так, чтобы их можно было распределить между гостями
    /// (сама Катя апельсины есть не будет), и всем гостям досталось поровну долек.
    ///
    /// Напишите программу, которая вычисляет минимальное количество долек, на которое необходимо разрезать каждый апельсин, чтобы были выполнены указанные выше условия.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит два положительных целых числа n и m (1 ≤ n, m ≤ 10^9).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите ответ на задачу.
    /// </summary>
    public class Task0394
    {
        public static void Main()
        {
            GetInputData(out var n, out var m);

            var result = Solve(n, m);

            PrintResult(result);
        }

        private static void GetInputData(out int n, out int m)
        {
            var input = Console.ReadLine().Split();
            
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
        }

        public static int Solve(int n, int m)
        {
            return n / Nod(n, m);
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }

        private static int Nod(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a >= b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return a + b;
        }
    }
}
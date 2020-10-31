using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 499 - "Турист"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 22%)
    /// 
    /// Гена собирается на туристический слет учеников своей школы. В своем классе он был назначен ответственным за палатки.
    /// У себя дома он нашел 3 палатки: первая из них весит a(1) килограмм и вмещает b(1) человек,
    /// вторая весит a(2) килограмм и вмещает b(2) человек, третья весит a(3) килограмм и вмещает b(3) человек.
    ///
    /// В классе Гены K человек. Выясните, может ли он выбрать палатки так, чтобы в них все могли поместиться.
    /// При этом учитывайте, что выбранные палатки должны суммарно весить не более W килограмм.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит два целых числа: K и W (1 ≤ K ≤ 15, 1 ≤ W ≤ 30).
    /// Вторая строка содержит шесть целых чисел: a(1), b(1), a(2), b(2), a(3), b(3) (1 ≤ a(1), a(2), a(3) ≤ 10, 1 ≤ b(1), b(2), b(3) ≤ 15).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите YES, если палатки указанным образом выбрать можно, и NO в противном случае.
    /// </summary>   
    public class Task0499
    {
        public static void Main()
        {
            GetInputData(out var k, out var w, out var a1, out var b1, out var a2, out var b2, out var a3, out var b3);

            var result = Solve(k, w, a1, b1, a2, b2, a3, b3);

            PrintResult(result);
        }

        private static void GetInputData(out int k, out int w, out int a1, out int b1, out int a2, out int b2, out int a3, out int b3)
        {
            var input1 = Console.ReadLine().Split();
            var input2 = Console.ReadLine().Split();
            
            k = int.Parse(input1[0]);
            w = int.Parse(input1[1]);
 
            a1 = int.Parse(input2[0]);
            b1 = int.Parse(input2[1]);
            a2 = int.Parse(input2[2]);
            b2 = int.Parse(input2[3]);
            a3 = int.Parse(input2[4]);
            b3 = int.Parse(input2[5]);
        }

        public static string Solve(int k, int w, int a1, int b1, int a2, int b2, int a3, int b3)
        {
            return a1 <= w && b1 >= k 
                   || a2 <= w && b2 >= k 
                   || a3 <= w && b3 >= k 
                   || a1 + a2 <= w && b1 + b2 >= k 
                   || a1 + a3 <= w && b1 + b3 >= k 
                   || a3 + a2 <= w && b3 + b2 >= k 
                   || a1 + a2 + a3 <= w && b1 + b2 + b3 >= k
                ? "YES"
                : "NO";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
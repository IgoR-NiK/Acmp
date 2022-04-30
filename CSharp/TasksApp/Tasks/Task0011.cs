using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 11 - "Зайчик"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 55%)
    /// 
    /// В нашем зоопарке появился заяц. Его поместили в клетку, и чтобы ему не было скучно, директор зоопарка распорядился поставить 
    /// в его клетке лесенку. Теперь наш зайчик может прыгать по лесенке вверх, перепрыгивая через ступеньки. 
    /// Лестница имеет определенное количество ступенек N. Заяц может одним прыжком преодолеть не более К ступенек. 
    /// Для разнообразия зайчик пытается каждый раз найти новый путь к вершине лестницы. Директору любопытно, сколько различных способов 
    /// есть у зайца добраться до вершины лестницы при заданных значениях K и N. Помогите директору написать программу, которая поможет 
    /// вычислить это количество. Например, если K=3 и N=4, то существуют следующие маршруты: 1+1+1+1, 1+1+2, 1+2+1, 2+1+1, 2+2, 1+3, 3+1. 
    /// Т.е. при данных значениях у зайца всего 7 различных маршрутов добраться до вершины лестницы.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записаны два натуральных числа K и N (1 ≤ K ≤ N ≤ 300). 
    /// К - максимальное количество ступенек, которое может преодолеть заяц одним прыжком, N – общее число ступенек лестницы.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести количество возможных вариантов различных 
    /// маршрутов зайца на верхнюю ступеньку лестницы без ведущих нулей.
    /// </summary>
    public class Task0011
    {
        public static void Main()
        {
            GetInputData(out var k, out var n);

            var result = Solve(k, n);

            PrintResult(result);
        }

        private static void GetInputData(out int k, out int n)
        {
            var input = Console.ReadLine().Split();

            k = int.Parse(input[0]);
            n = int.Parse(input[1]);
        }

        public static string Solve(int k, int n)
        {
            var a = new byte[n + 1][];

            a[0] = new byte[] { 1 };
            for (var i = 1; i <= n; i++)
            {
                a[i] = new byte[] { 0 };
                for (var j = i - k > 0 ? i - k : 0; j < i; j++)
                    a[i] = Sum(a[i], a[j]);
            }

            var output = string.Empty;
            for (var i = a[n].Length - 1; i >= 0; i--)
                output += a[n][i];

            return output;
        }

        private static void PrintResult(string result)
        {
            Console.Write(result);
        }

        private static byte[] Sum(byte[] a, byte[] b)
        {
            var maxLength = Math.Max(a.Length, b.Length);
            byte[] ch1 = new byte[maxLength], ch2 = new byte[maxLength], output = new byte[maxLength];
            byte p = 0;

            a.CopyTo(ch1, 0);
            b.CopyTo(ch2, 0);

            for (var i = 0; i < maxLength; i++)
            {
                var k = (byte)(ch1[i] + ch2[i] + p);
                if (k > 9)
                {
                    p = 1;
                    output[i] = (byte)(k % 10);
                }
                else
                {
                    p = 0;
                    output[i] = k;
                }
            }
            
            if (p == 1)
            {
                var temp = new byte[maxLength + 1];
                output.CopyTo(temp, 0);
                temp[maxLength] = 1;
                return temp;
            }

            return output;
        }
    }
}
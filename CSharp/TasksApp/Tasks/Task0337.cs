using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 337 - "Лампочки"
    /// (Время: 2 сек. Память: 16 Мб Сложность: 94%)
    /// 
    /// Имеется ряд из N лампочек, которые пронумерованы от 1 до N. Изначально ни одна из лампочек не горит. 
    /// Далее происходит K последовательных линейных инверсий этого ряда ламп. Под линейной инверсией понимается инверсия каждой P-й лампочки в ряде. 
    /// Например, если P=3, то произойдет инверсия 3й, 6й, 9й и т.д. лампочек. 
    /// 
    /// Требуется определить: сколько горящих лампочек останется после реализации всех заданных линейных инверсий?
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT заданы числа N и K – число лампочек и число линейных инверсий. 
    /// Вторая строка состоит из K целых чисел P(i), задающих период данных инверсий (1 ≤ N ≤ 10^9, 1 ≤ K ≤ 100, 1 ≤ P(i) ≤ 50).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT следует вывести ответ на задачу.
    /// </summary>
    public class Task0337
    {
        public static void Main()
        {
            uint n;
            byte[] p;
            GetInputData(out n, out p);

            var result = Solve(n, p);

            PrintResult(result);
        }

        private static void GetInputData(out uint n, out byte[] p)
        {
            var input = Console.ReadLine().Split();
            n = uint.Parse(input[0]);
            var k = byte.Parse(input[1]);

            input = Console.ReadLine().Split();
            p = new byte[k];
            for (var i = 0; i < k; i++)
                p[i] = byte.Parse(input[i]);
        }

        public static long Solve(uint n, byte[] p)
        {
            const int Max = 200000;
            var lightbulb = new Light[Max];

            var c = new byte[51];
            for (var i = 0; i < p.Length; i++)
                c[p[i]]++;

            c[1] %= 2;

            var currentCount = 0;
            for (uint j = 2; j < 51; j++)
            {
                c[j] %= 2;
                if (c[j] != 0)
                {
                    lightbulb[currentCount].Number = j;
                    lightbulb[currentCount].N = 1;
                    currentCount++;

                    for (int k = 0, l = currentCount - 1; k < l; k++)
                    {
                        var q = NOK(j, lightbulb[k].Number);

                        if (q <= n)
                        {
                            lightbulb[currentCount].Number = (uint)q;
                            lightbulb[currentCount].N = -2 * lightbulb[k].N;
                            currentCount++;
                        }
                    }

                    QuickSort(lightbulb, 0, currentCount - 1);

                    uint temp = 0;
                    int index = 0, nach = 0;
                    for (var i = 0; i < currentCount; i++)
                    {
                        if (temp != lightbulb[i].Number)
                        {
                            lightbulb[index].Number = lightbulb[i].Number;
                            lightbulb[index].N = lightbulb[i].N;

                            temp = lightbulb[i].Number;
                            nach = index;
                            index++;
                        }
                        else
                        {
                            lightbulb[nach].N += lightbulb[i].N;
                        }
                    }

                    currentCount = index;
                }
            }

            long sum = 0;

            for (var i = 0; i < currentCount; i++)
                sum += (n / lightbulb[i].Number) * lightbulb[i].N;

            if (c[1] == 1)
                sum = n - sum;

            return sum;
        }

        private static void PrintResult(long result)
        {
            Console.Write(result);
        }


        struct Light
        {
            public uint Number;
            public int N;
        }

        private static ulong NOK(ulong a, ulong b)
        {
            return (b / NOD(a, b)) * a;
        }

        private static ulong NOD(ulong a, ulong b)
        {
            while (b > 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        private static void QuickSort(Light[] lightbulb, int low, int high)
        {
            var x = lightbulb[(low + high) / 2];
            var i = low;
            var j = high;
            while (i <= j)
            {
                while (lightbulb[i].Number < x.Number) i++;
                while (lightbulb[j].Number > x.Number) j--;
                if (i <= j)
                {
                    var temp = lightbulb[i];
                    lightbulb[i] = lightbulb[j];
                    lightbulb[j] = temp;

                    i++;
                    j--;
                }
            }

            if (j > low) QuickSort(lightbulb, low, j);
            if (high > i) QuickSort(lightbulb, i, high);
        }
    }
}
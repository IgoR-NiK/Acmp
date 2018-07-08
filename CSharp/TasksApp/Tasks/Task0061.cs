using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 61 - "Баскетбол"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 5%)
    /// 
    /// Известны результаты каждой из 4х четвертей баскетбольной встречи. Нужно определить победителя матча.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит 4 строки, в каждой строке находится два целых числа a и b – итоговый счет в соответствующей четверти. 
    /// а – количество набранных очков за четверть первой командой, b – количество очков, набранных за четверть второй командой. (0 ≤ a,b ≤ 100).
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите номер выигравшей команды, в случае ничьей следует вывести «DRAW».
    /// </summary>
    public static class Task0061 
    {
        public static void Main()
        {            
            int[] a, b;
            GetInputData(out a, out b);

            var result = Solve(a, b);

            PrintResult(result);  
        }

        private static void GetInputData(out int[] a, out int[] b)
        {
            const int count = 4;

            a = new int[count];
            b = new int[count];

            for (var i = 0; i < count; i++)
            {
                var inputData = Console.ReadLine().Split();
                a[i] = int.Parse(inputData[0]);
                b[i] = int.Parse(inputData[1]);
            }            
        }

        public static string Solve(int[] a, int[] b)
        {
            var sumA = 0;
            var sumB = 0;
            for (var i = 0; i < a.Length; i++)
            {
                sumA += a[i];
                sumB += b[i];
            }

            return sumA > sumB ? "1" : (sumA < sumB ? "2" : "DRAW");
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
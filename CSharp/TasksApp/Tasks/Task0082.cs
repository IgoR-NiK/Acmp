using System;
using System.Text;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 82 - "Пересечение множеств"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 34%)
    /// 
    /// Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
    /// Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записано через пробел два целых числа N и М (1 ≤ N, М ≤ 300 000) — количество элементов первого и второго наборов, 
    /// соответственно. В следующих строках записано сначала N чисел первого набора, а затем M чисел второго набора. 
    /// Числа разделены пробелами или символами конца строки. Каждое из этих чисел попадает в промежуток от 0 до 10^5.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно записать в возрастающем порядке без повторений все числа, которые входят как в первый, так и во второй набор. 
    /// Числа разделять одним пробелом. Если таких чисел нет, то выходной файл должен оставаться пустым.
    /// </summary>
    public static class Task0082 
    {
        public static void Main()
        {            
            int[] arrayN, arrayM;
            GetInputData(out arrayN, out arrayM);

            var result = Solve(arrayN, arrayM);

            PrintResult(result);  
        }

        private static void GetInputData(out int[] arrayN, out int[] arrayM)
        {
            var input = Console.ReadLine();
            var n = int.Parse(input.Split()[0]);
            var m = int.Parse(input.Split()[1]);

            arrayN = new int[n];
            arrayM = new int[m];

            var index = 0;
            var number = new StringBuilder();
            while (true)
            {
                var ch = Console.Read();
                if (ch != -1 && Char.IsDigit((char)ch))
                {
                    number.Append((char)ch);
                    continue;
                }
                else
                {
                    int num;
                    if (int.TryParse(number.ToString(), out num))
                    {
                        if (index < n)
                        {
                            arrayN[index] = num;
                        }
                        else if (index < n + m)
                        {
                            arrayM[index - n] = num;                            
                        }
                        else
                        {
                            break;
                        }

                        number.Clear();
                        index++;
                    }
                    else
                    {
                        if (index < n + m)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static int[] Solve(int[] arrayN, int[] arrayM)
        {
            var count = 0;

            var temp = new int[100001];
            foreach (var e in arrayN)
            {
                if (temp[e] == 0)
                    temp[e]++;
            }
            foreach (var e in arrayM)
            {
                if (temp[e] == 1)
                {
                    count++;
                    temp[e]++;
                }
            }

            var result = new int[count];
            for (int i = 0, k = 0; i < 100001; i++)
            {
                if (temp[i] == 2)
                {
                    result[k] = i;
                    k++;
                }
            }

            return result;
        }

        private static void PrintResult(int[] result)
        {
            Array.ForEach(result, x => Console.Write("{0} ", x));
        }
    }
}
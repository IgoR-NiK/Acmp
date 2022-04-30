using System;
using System.Collections.Generic;
using System.Text;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 103 - "Снова A+B"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 35%)
    /// 
    /// Требуется сложить два целых числа А и В.
    /// 
    /// Входные данные
    /// Во входном файле INPUT.TXT записано два неотрицательных целых числа, не превышающих 10^100, по одному в каждой строке.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В, без лидирующих нулей.
    /// </summary>
    public static class Task0103
    {
        public static void Main()
        {
            GetInputData(out var a, out var b);

            var result = Solve(a, b);

            PrintResult(result);  
        }

        private static void GetInputData(out BigInteger a, out BigInteger b)
        {
            a = new BigInteger(Console.ReadLine());
            b = new BigInteger(Console.ReadLine());
        }

        public static BigInteger Solve(BigInteger a, BigInteger b)
        {
            return a + b;
        }

        private static void PrintResult(BigInteger result)
        {
            Console.WriteLine(result);
        }
        
        public class BigInteger
        {
            // Массив, который хранит большое число
            private readonly List<int> _arr = new List<int>();

            // Количество цифр в одном элементе массива    
            private static readonly int Order = 8;

            public BigInteger() { }
            public BigInteger(string s)
            {
                int whole = s.Length / Order, rest = s.Length % Order;

                for (var i = 1; i <= whole; i++)
                    _arr.Add(int.Parse(s.Substring(s.Length - Order * i, Order)));

                if (rest != 0)
                    _arr.Add(int.Parse(s.Substring(0, rest)));
            }

            public BigInteger(List<int> arr)
            {
                _arr = arr;
            }

            // Сложение двух больших неотрицательных чисел
            public static BigInteger operator +(BigInteger a, BigInteger b)
            {
                var c = new BigInteger();

                int max = Math.Max(a._arr.Count, b._arr.Count), k = 0, myBase = (int)Math.Pow(10, Order);
                for (var i = 0; i < max; i++)
                {
                    var tempA = a._arr.Count > i ? a._arr[i] : 0;
                    var tempB = b._arr.Count > i ? b._arr[i] : 0;

                    c._arr.Add(tempA + tempB + k);
                    if (c._arr[i] >= myBase)
                    {
                        k = 1;
                        c._arr[i] -= myBase;
                    }
                    else
                    {
                        k = 0;
                    }
                }
                if (k == 1) c._arr.Add(k);

                return c;
            }

            // Умножение большого неотрицательного числа на короткое неотрицательное число
            public static BigInteger operator *(BigInteger a, int b)
            {
                var c = new BigInteger();

                int k = 0, myBase = (int)Math.Pow(10, Order);
                for (var i = 0; i < a._arr.Count; i++)
                {
                    var temp = a._arr[i] * (long)b + k;
                    c._arr.Add((int)(temp % myBase));
                    k = (int)(temp / myBase);
                }
                c._arr.Add(k);
                Normalize(c._arr);

                return c;
            }

            // Умножение большого неотрицательного числа на большое неотрицательное число
            public static BigInteger operator *(BigInteger a, BigInteger b)
            {
                var c = new BigInteger("0");

                for (var i = 0; i < a._arr.Count; i++)
                {
                    var temp = b * a._arr[i];
                    if (temp._arr[temp._arr.Count - 1] != 0)
                    {
                        for (var j = 0; j < i; j++)
                            temp._arr.Insert(0, 0);
                        c += temp;
                    }
                }

                return c;
            }

            // Возведение в степень
            public BigInteger Pow(int k)
            {
                var a = new BigInteger(_arr);
                var b = new BigInteger("1");

                while (k > 0)
                {
                    if (k % 2 == 0)
                    {
                        k = k / 2;
                        a = a * a;
                    }
                    else
                    {
                        k = k - 1;
                        b = b * a;
                    }
                }

                return b;
            }

            // Вывод большого числа
            public override string ToString()
            {
                var ans = new StringBuilder();

                ans.Append(_arr[_arr.Count - 1].ToString());
                for (var i = _arr.Count - 2; i >= 0; i--)
                    ans.Append(_arr[i].ToString().PadLeft(Order, '0'));

                return ans.ToString();
            }

            // Удаление лидирующих нулей
            private static void Normalize(List<int> arr)
            {
                while (arr.Count > 1 && arr[arr.Count - 1] == 0)
                    arr.RemoveAt(arr.Count - 1);
            }

            // Сравнение двух больших чисел
            public int CompareTo(BigInteger another)
            {
                if (_arr.Count > another._arr.Count)
                {
                    return 1;
                }

                if (_arr.Count < another._arr.Count)
                {
                    return -1;
                }
                for (var i = 0; i < _arr.Count; i++)
                {
                    if (_arr[i] > another._arr[i])
                    {
                        return 1;
                    }

                    if (_arr[i] < another._arr[i])
                    {
                        return -1;
                    }
                }

                return 0;
            }
        }
    }
}
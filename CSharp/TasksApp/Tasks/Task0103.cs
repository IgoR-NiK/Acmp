﻿using System;
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
            BigInteger a, b;
            GetInputData(out a, out b);

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
            private List<int> arr = new List<int>();

            // Количество цифр в одном элементе массива    
            private static int order = 8;

            public BigInteger() { }
            public BigInteger(string s)
            {
                int whole = s.Length / order, rest = s.Length % order;

                for (int i = 1; i <= whole; i++)
                    arr.Add(int.Parse(s.Substring(s.Length - order * i, order)));

                if (rest != 0)
                    arr.Add(int.Parse(s.Substring(0, rest)));
            }

            public BigInteger(List<int> arr)
            {
                this.arr = arr;
            }

            // Сложение двух больших неотрицательных чисел
            public static BigInteger operator +(BigInteger A, BigInteger B)
            {
                BigInteger C = new BigInteger();

                int max = Math.Max(A.arr.Count, B.arr.Count), k = 0, myBase = (int)Math.Pow(10, order);
                for (int i = 0; i < max; i++)
                {
                    int tempA = (A.arr.Count > i) ? A.arr[i] : 0;
                    int tempB = (B.arr.Count > i) ? B.arr[i] : 0;

                    C.arr.Add(tempA + tempB + k);
                    if (C.arr[i] >= myBase)
                    {
                        k = 1;
                        C.arr[i] -= myBase;
                    }
                    else
                    {
                        k = 0;
                    }
                }
                if (k == 1) C.arr.Add(k);

                return C;
            }

            // Умножение большого неотрицательного числа на короткое неотрицательное число
            public static BigInteger operator *(BigInteger A, int B)
            {
                BigInteger C = new BigInteger();

                int k = 0, myBase = (int)Math.Pow(10, order);
                for (int i = 0; i < A.arr.Count; i++)
                {
                    long temp = (long)A.arr[i] * (long)B + k;
                    C.arr.Add((int)(temp % myBase));
                    k = (int)(temp / myBase);
                }
                C.arr.Add(k);
                Normalize(C.arr);

                return C;
            }

            // Умножение большого неотрицательного числа на большое неотрицательное число
            public static BigInteger operator *(BigInteger A, BigInteger B)
            {
                BigInteger C = new BigInteger("0");

                for (int i = 0; i < A.arr.Count; i++)
                {
                    BigInteger temp = B * A.arr[i];
                    if (temp.arr[temp.arr.Count - 1] != 0)
                    {
                        for (int j = 0; j < i; j++)
                            temp.arr.Insert(0, 0);
                        C = C + temp;
                    }
                }

                return C;
            }

            // Возведение в степень
            public BigInteger Pow(int k)
            {
                BigInteger a = new BigInteger(arr);
                BigInteger b = new BigInteger("1");

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
                StringBuilder ans = new StringBuilder();

                ans.Append(arr[arr.Count - 1].ToString());
                for (int i = arr.Count - 2; i >= 0; i--)
                    ans.Append(arr[i].ToString().PadLeft(order, '0'));

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
                if (this.arr.Count > another.arr.Count)
                {
                    return 1;
                }
                else if (this.arr.Count < another.arr.Count)
                {
                    return -1;
                }
                else
                {
                    for (var i = 0; i < arr.Count; i++)
                    {
                        if (arr[i] > another.arr[i])
                        {
                            return 1;
                        }
                        else if (arr[i] < another.arr[i])
                        {
                            return -1;
                        }
                    }
                }

                return 0;
            }
        }
    }
}
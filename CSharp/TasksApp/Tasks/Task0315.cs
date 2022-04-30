﻿using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 315 - "Наименьшая система счисления"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 26%)
    /// 
    /// Известно, что основанием позиционной системы счисления называют количество различных символов, используемых для записи чисел в данной системе счисления. 
    /// Также известно, что любое число x в b-ичной системе счисления имеет вид x=a(0)∙b(0)+a(1)∙b(1)+…+a(n)∙b(n), где b ≥ 2 и 0 ≤ a(i) &lt; b.
    /// 
    /// Для записи чисел в b-ичной системе счисления, где b ≤ 36, могут быть использованы первые b символов из следующего списка 0,1,…, 9, A, B, …, Z.
    /// Например, для записи чисел в троичной системы используются символы 0, 1, 2, а в двенадцатеричной - 0,1,…, 9, A, B.
    /// 
    /// Требуется написать программу, которая по входной строке S определит, является ли данная строка записью числа в системе счисления, 
    /// с основанием не большим 36, и, если является, определит минимальное основание этой системы счисления.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит в единственной строке входную непустую строку. Длина строки не превышает 255. Все символы строки имеют коды от 32 до 127.
    /// 
    /// Выходные данные
    /// Выходной файл OUTPUT.TXT должен содержать одно число. Если строка является записью числа в некоторой системе счисления, 
    /// то нужно вывести минимальное основание такой системы счисления. Иначе вывести -1.
    /// </summary>
    public static class Task0315
    {
        public static void Main()
        {
            GetInputData(out var n);

            var result = Solve(n);

            PrintResult(result);
        }

        private static void GetInputData(out string n)
        {
            n = Console.ReadLine();
        }

        public static int Solve(string n)
        {
            var max = 49;

            for (var i = 0; i < n.Length; i++)
            {
                var symbol = n[i];

                if (symbol < 48 || symbol > 57 && symbol < 65 || symbol > 90)
                    return -1;

                if (symbol > max)
                    max = symbol;
            }

            return max <= 57 ? max - 47 : max - 54;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
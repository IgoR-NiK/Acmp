﻿using System;
 
namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 818 - "Кипячение чая"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 14%)
    /// 
    /// В эту субботу у Васи день рождения и через 15 минут к нему придут гости.
    /// Ему срочно надо вскипятить чай, для того чтобы напоить им гостей.
    /// У Васи дома есть много литровых чайников (можно считать, что их бесконечное количество), а розетка всего одна.
    /// Т.к. вода кипятится очень долго, за 15 минут она успеет вскипятиться максимум один раз.
    /// Но Вася – мальчик не промах, он достал из кладовки N тройников, в i-том тройнике a(i) разъемов.
    /// Теперь Вася ломает голову: как ему соединить тройники и воткнуть эту систему в розетку,
    /// чтобы максимизировать количество чайников, которые он сможет поставить кипятить.
    ///
    /// Ваша задача заключается в написании программы, которая определит максимальное число чайников,
    /// которые возможно использовать для кипячения чая, используя данные тройники.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT содержится число N (1 ≤ N ≤ 10^5) – количество тройников.
    /// Во второй строке через пробел перечислены числа a(i) (1 ≤ a(i) ≤ 1000, 1 ≤ i ≤ N) – информация о тройниках.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите ответ на задачу.
    /// </summary>
    public static class Task0818 
    {
        public static void Main()
        {            
            GetInputData(out var numbers);
 
            var result = Solve(numbers);
 
            PrintResult(result);  
        }
 
        private static void GetInputData(out int[] numbers)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();
 
            numbers = new int[n];
            for (var i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
        }
 
        public static int Solve(int[] numbers)
        {
            var result = 1;
 
            for (var i = 0; i < numbers.Length; i++)
            {
                result += numbers[i] - 1;
            }
 
            return result;
        }
 
        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
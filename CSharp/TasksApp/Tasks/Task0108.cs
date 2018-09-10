﻿using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 108 - "Неглухой телефон"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 1%)
    /// 
    /// Возможно, что Вы когда то играли в игру «Глухой телефон», либо слышали о ней. В этой игре участникам приходится передавать информацию друг другу различными способами: 
    /// словесно, образно, бывает даже приходится писать левой рукой текст, который другой участник команды должен будет прочитать. 
    /// Так же известно, что практически никогда передаваемая информация не доходит до конечного адресата. 
    /// Обозначим за Fi(x) функцию, которая преобразует текст передаваемой информации x в ту, которую получит участник i+1 от участника i. 
    /// Тогда последний n-й участник получит данные y, которые будут выражаться следующей формулой:
    /// 
    /// y = Fn-1(Fn-2(…F2(F1(x))))
    /// 
    /// Но Вам необходимо исключить какие-либо внешние факторы, которые могут исказить исходную информацию и Вы должны реализовать программу «неглухой телефон», 
    /// которая сможет безошибочно доставлять исходные данные, т.е. в нашем случае функция Fi(x) = x для всех i от 1 до n-1.
    /// 
    /// Входные данные
    /// В единственной строке входного файла INPUT.TXT записано натуральное число от 1 до 100.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно вывести в точности то же число, которое задано во входном файле.
    /// </summary>
    public class Task0108
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out int input)
        {
            input = int.Parse(Console.ReadLine());
        }

        public static int Solve(int input)
        {
            return input;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
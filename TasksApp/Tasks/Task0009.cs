using System;
using System.Linq;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 9 - "Домашнее задание"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 27%)
    /// 
    /// Петя успевает по математике лучше всех в классе, поэтому учитель задал ему сложное домашнее задание, 
    /// в котором нужно в заданном наборе целых чисел найти сумму всех положительных элементов, затем найти где 
    /// в заданной последовательности находятся максимальный и минимальный элемент и вычислить произведение чисел, 
    /// расположенных между ними. Так же известно, что минимальный и максимальный элемент встречаются в заданном 
    /// множестве чисел только один раз. Поскольку задач такого рода учитель дал Пете около ста, то Петя как сильный 
    /// программист смог написать программу, которая по заданному набору чисел самостоятельно находит решение. А Вам слабо?
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов массива. 
    /// Вторая строка содержит N целых чисел, представляющих заданный массив. Все элементы массива разделены пробелом. 
    /// Каждое из чисел во входном файле не превышает 10^2 по абсолютной величине.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести два числа, разделенных пробелом: 
    /// сумму положительных элементов и произведение чисел, расположенных между минимальным и максимальным элементами. 
    /// Значения суммы и произведения не превышают по модулю 3*10^4.
    /// </summary>
    public class Task0009
    {
        public static void Main()
        {
            int n;
            int[] array;
            GetInputData(out n, out array);

            var result = Solve(n, array);

            PrintResult(result);
        }

        private static void GetInputData(out int n, out int[] array)
        {
            n = int.Parse(Console.ReadLine());            
            var input = Console.ReadLine().Split();

            array = new int[n];
            for(var i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
            }
        }

        public static Result Solve(int n, int[] array)
        {
            var maxIndex = Array.IndexOf(array, array.Max());
            var minIndex = Array.IndexOf(array, array.Min());

            var mul = 1;
            for (var i = Math.Min(maxIndex, minIndex) + 1; i < Math.Max(maxIndex, minIndex); i++)
            {
                mul *= array[i];
            }

            var result = new Result
            {
                Sum = array.Sum(x => (x > 0) ? x : 0),
                Mul = mul
            };

            return result;
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }        
    }

    public class Result
    {
        public int Sum { get; set; }
        public int Mul { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Sum, Mul);
        }
    }
}
using System;
using System.Linq;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 81 - "Арбузы"
    /// (Время: 0,5 сек. Память: 16 Мб Сложность: 14%)
    /// 
    /// Иван Васильевич пришел на рынок и решил купить два арбуза: один для себя, а другой для тещи. 
    /// Понятно, что для себя нужно выбрать арбуз потяжелей, а для тещи полегче. 
    /// Но вот незадача: арбузов слишком много и он не знает как же выбрать самый легкий и самый тяжелый арбуз? Помогите ему!
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT задано одно число N – количество арбузов. 
    /// Вторая строка содержит N чисел, записанных через пробел. Здесь каждое число – это масса соответствующего арбуза. Все числа натуральные и не превышают 30000.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно вывести два числа через пробел: массу арбуза, который Иван Васильевич купит теще и массу арбуза, который он купит себе.
    /// </summary>
    public static class Task0081 
    {
        public static void Main()
        {
            GetInputData(out var array);

            var result = Solve(array);

            PrintResult(result);  
        }

        private static void GetInputData(out int[] array)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();

            array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = int.Parse(input[i]);
            }
        }

        public static Result Solve(int[] array)
        {
            return new Result { Max = array.Max(), Min = array.Min() };
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }

        public struct Result
        {
            public int Max;
            public int Min;

            public override string ToString()
            {
                return $"{Min} {Max}";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 5 - "Статистика"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
    /// 
    /// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником. 
    /// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки. 
    /// Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, 
    /// сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках. 
    /// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100). 
    /// Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – натуральное число от 1 до 31. 
    /// Все элементы массива разделены пробелом. 
    /// 
    /// Выходные данные
    /// В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки, 
    /// а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки. В третьей строке нужно вывести «YES», 
    /// если Вася может рассчитывать на четверку и «NO» в противном случае. В каждой строчке числа следует выводить в том же порядке, 
    /// в котором они идут во входных данных. При выводе, числа отделяются пробелом.
    /// </summary>
    public class Task0005
    {
        public static void Main()
        {
            GetInputData(out var n, out var days);

            var result = Solve(n, days);

            PrintResult(result);
        }

        private static void GetInputData(out int n, out int[] days)
        {            
            n = int.Parse(Console.ReadLine());            
            var str = Console.ReadLine().Split();

            days = new int[n];
            for (var i = 0; i < str.Length; i++)
                days[i] = int.Parse(str[i]);                
        }

        public static Output Solve(int n, int[] days)
        {
            var output = new Output();

            foreach (var day in days)
            {
                switch(day % 2)
                {
                    case 0:
                        output.EvenDays.Add(day);
                        break;
                    case 1:
                        output.OddDays.Add(day);
                        break;
                }
            }

            return output;
        }

        private static void PrintResult(Output result)
        {
            Console.WriteLine(result);
        }

        public class Output
        {
            /// <summary>
            /// Нечётные дни
            /// </summary>
            public List<int> OddDays = new List<int>();

            /// <summary>
            /// Чётные дни
            /// </summary>
            public List<int> EvenDays = new List<int>();

            /// <summary>
            /// Ответ на задачу
            /// </summary>
            public string Answer => OddDays.Count > EvenDays.Count ? "NO" : "YES";

            public override string ToString()
            {
                var sb = new StringBuilder();

                foreach(var day in OddDays)
                {
                    sb.Append(day);
                    sb.Append(' ');
                }
                sb.Append(Environment.NewLine);

                foreach (var day in EvenDays)
                {
                    sb.Append(day);
                    sb.Append(' ');
                }
                sb.Append(Environment.NewLine);
                
                sb.Append(Answer);

                return sb.ToString();
            }

        }
    }
}
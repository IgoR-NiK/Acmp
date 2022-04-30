using System;
using System.Linq;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 32 - "Годовой баланс"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 35%)
    /// 
    /// В конторе «Рога и Копыта» подходит время подведения годового баланса. В бухгалтерию поступили сведения о том, что, согласно документам,
    /// суммарный расход составил а рублей, a суммарный приход – b рублей. Поскольку с реальным положением дел эти цифры все равно не имеют ничего общего,
    /// бухгалтер решил реализовать следующую свою идею. Как известно, при наборе чисел на компьютере люди часто вводят цифры в неправильном порядке.
    /// Поэтому бухгалтер хочет найти такой способ переставить цифры в числах a и b, чтобы в результате разность a-b (и, соответственно, количество денег,
    /// которые он положит к себе в карман), была максимальна, а в случае можно будет сослаться на ошибку секретаря. При этом нельзя забывать о знаке чисел
    /// и о том, что ноль не может быть первой цифрой числа, отличного от ноля. Напишите программу, которая поможет бухгалтеру.
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит два целых числа a и b (-10^9 &lt; a,b &lt; 10^9).
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите одно целое число – наибольшую разность чисел,
	/// первое из которых может быть получено перестановкой цифр a, а второе – перестановкой цифр b.
    /// </summary>
    public class Task0032
    {
        public static void Main()
        {
            GetInputData(out var a, out var b);
            
            var result = Solve(a, b);

            PrintResult(result);
        }

        private static void GetInputData(out int a, out int b)
        {
	        a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public static int Solve(int a, int b)
        {
            var first = int.Parse(a < 0 ? "-" + SortAsc($"{a}".Substring(1)) : SortDesc($"{a}"));
            var second = int.Parse(b < 0 ? "-" + SortDesc($"{b}".Substring(1)) : SortAsc($"{b}"));

            return first - second;
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }

        private static string SortAsc(string value)
        {
            if (value == "0")
                return value;

            var numbers = value.ToCharArray();

            var sortedNumbers = numbers.OrderBy(c => c).ToList();

            if (sortedNumbers.First() == '0')
            {
                var index = sortedNumbers.FindIndex(c => c != '0');

                var temp = sortedNumbers[0];
                sortedNumbers[0] = sortedNumbers[index];
                sortedNumbers[index] = temp;
            }

            var result = string.Join("", sortedNumbers);
            
            return result;
        }

        private static string SortDesc(string value)
        {
            var result = string.Join("", value.ToCharArray().OrderByDescending(c => c));

            return result;
        }
    }
}
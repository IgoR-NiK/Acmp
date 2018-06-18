using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 7 - "Золото племени АББА"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 30%)
    /// 
    /// Главный вождь племени Абба не умеет считать. В обмен на одну из его земель вождь другого племени предложил ему выбрать одну из трех куч 
    /// с золотыми монетами. Но вождю племени Абба хочется получить наибольшее количество золотых монет. Помогите вождю сделать правильный выбор!
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записаны три натуральных числа через пробел. 
    /// Каждое из чисел не превышает 10^100. Числа записаны без ведущих нулей.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT нужно вывести одно целое число — максимальное количество монет, которые может взять вождь.
    /// </summary>
    public class Task0007
    {
        public static void Main()
        {
            string a, b, c;
            GetInputData(out a, out b, out c);

            var result = Solve(a, b, c);

            PrintResult(result);
        }

        private static void GetInputData(out string a, out string b, out string c)
        {
            var input = Console.ReadLine().Split();

            a = input[0];
            b = input[1];
            c = input[2];
        }

        public static string Solve(string a, string b, string c)
        {
            return Compare(a, b, c);
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
        
        private static string Compare(string s1, string s2, string s3)
        {
            string temp = Compare(s1, s2);
            return Compare(temp, s3);
        }

        private static string Compare(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return s1;

            if (s1.Length < s2.Length)
                return s2;
                        
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return s1;
                else if (s1[i] < s2[i]) return s2;
            }

            return s1;
        }
    }
}
using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 107 - "Красивые номера"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 52%)
    /// 
    /// Вы, наверное, замечали, что многие компании используют для рекламы «красивые» номера телефонов, которые удобны для запоминания потенциальными клиентами. 
    /// Но что делать, если номер вашей компании ничем не примечателен? Можно присмотреться к нему повнимательнее, а вдруг, 
    /// если перегруппировать цифры номера некоторым образом, номер станет намного красивее? 
    /// Например, если у вашей компании номер 872-73-33, то его можно сделать красивее, если перегруппировать цифры так: 8727-333.
    ///
    /// Введем следующую оценку красоты разбиения номера. Будем разбивать номер дефисами на группы размером от 2 до 4 цифр.
    /// Теперь красотой разбиения назовем сумму баллов, которые приносит каждая группа. Эти баллы будем считать, пользуясь приведенной таблицей.
    /// 
    /// aa	                        2
    /// aba	                        2
    /// aab, abb	                2
    /// aaa	                        3
    /// abac, baca	                2
    /// abab	                    3
    /// aabb	                    3
    /// abba	                    4
    /// baaa, abaa, aaba, aaab	    3
    /// aaaa	                    5 
    /// 
    /// В этой таблице символами «а», «b», «с» обозначены различные цифры. 
    /// Например, под шаблон «aab» подходят группы «223», «667», но не подходят «123» и «888». 
    /// Пользуясь предложенной оценкой, найдите наиболее красивое разбиение заданного номера.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит одну строку из 7 цифр – заданный телефонный номер.
    /// 
    /// Выходные данные
    /// Выведите в первой строке выходного файла OUTPUT.TXT наиболее красивое разбиение номера, а во второй – величину его красоты. 
    /// Если разбиений с максимальной величиной красоты несколько, выведите в выходной файл любое из этих разбиений.
    /// </summary>
    public class Task0107
    {
        public static void Main()
        {
            string input;
            GetInputData(out input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();
        }

        public static Result Solve(string input)
        {
            var rating = new int[5];
            rating[0] = Count(input.Substring(0, 4), input.Substring(4, 3));
            rating[1] = Count(input.Substring(3, 4), input.Substring(0, 3));
            rating[2] = Count(input.Substring(0, 3), input.Substring(3, 2), input.Substring(5, 2));
            rating[3] = Count(input.Substring(2, 3), input.Substring(0, 2), input.Substring(5, 2));
            rating[4] = Count(input.Substring(4, 3), input.Substring(0, 2), input.Substring(2, 2));

            int max = 0, index = 0;
            for (var i = 0; i < 5; i++)
            {
                if (rating[i] >= max)
                {
                    max = rating[i];
                    index = i;
                }
            }

            var result = new Result();
            switch (index)
            {
                case 0:
                    result.Number = String.Format("{0}-{1}", input.Substring(0, 4), input.Substring(4, 3));
                    break;
                case 1:
                    result.Number = String.Format("{0}-{1}", input.Substring(0, 3), input.Substring(3, 4));
                    break;
                case 2:
                    result.Number = String.Format("{0}-{1}-{2}", input.Substring(0, 3), input.Substring(3, 2), input.Substring(5, 2));
                    break;
                case 3:
                    result.Number = String.Format("{0}-{1}-{2}", input.Substring(0, 2), input.Substring(2, 3), input.Substring(5, 2));
                    break;
                case 4:
                    result.Number = String.Format("{0}-{1}-{2}", input.Substring(0, 2), input.Substring(2, 2), input.Substring(4, 3));
                    break;
            }

            result.Weight = max;
            return result;
        }

        private static void PrintResult(Result result)
        {
            Console.WriteLine(result);
        }

        public class Result
        {
            public string Number { get; set; }
            public int Weight { get; set; }

            public override string ToString()
            {
                return String.Format("{0}\n{1}", Number, Weight);
            }
        }

        static int Count(string a, string b)
        {
            var s = 0;

            if (a[0] == a[1] && a[1] == a[2] && a[2] == a[3]) s += 5;
            else if (a[1] == a[2] && a[2] == a[3] || a[0] == a[2] && a[2] == a[3] || a[0] == a[1] && a[1] == a[3] || a[0] == a[1] && a[1] == a[2]) s += 3;
            else if (a[0] == a[3] && a[1] == a[2]) s += 4;
            else if (a[0] == a[1] && a[2] == a[3]) s += 3;
            else if (a[0] == a[2] && a[1] == a[3]) s += 3;
            else if (a[0] == a[2] || a[1] == a[3]) s += 2;

            if (b[0] == b[1] && b[1] == b[2]) s += 3;
            else if (b[0] == b[1] || b[1] == b[2]) s += 2;
            else if (b[0] == b[2]) s += 2;

            return s;
        }

        static int Count(string a, string b, string c)
        {
            var s = 0;

            if (a[0] == a[1] && a[1] == a[2]) s += 3;
            else if (a[0] == a[1] || a[1] == a[2]) s += 2;
            else if (a[0] == a[2]) s += 2;

            if (b[0] == b[1]) s += 2;
            if (c[0] == c[1]) s += 2;

            return s;
        }
    }
}
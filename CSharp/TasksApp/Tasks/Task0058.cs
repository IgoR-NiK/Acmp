using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 58 - "Проверка на симпатичность"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 28%)
    /// 
    /// Рассмотрим таблицу, содержащую n строк и m столбцов, в каждой клетке которой расположен ноль или единица. 
    /// Назовем такую таблицу симпатичной, если в ней нет ни одного квадрата 2 на 2, заполненного целиком нулями или целиком единицами.
    /// 
    /// Задано несколько таблиц. Необходимо для каждой из них выяснить, является ли она симпатичной.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит количество t (1 ≤ t ≤ 10) наборов входных данных. 
    /// Далее следуют описания этих наборов. Описание каждого набора состоит из строки, содержащей числа n и m (1 ≤ n,m ≤ 100), 
    /// и n строк, каждая из которых содержит по m чисел, разделенных пробелами. 
    /// j-ое число в i+1-ой строке описания набора входных данных - элемент a(ij) соответствующей таблицы. Гарантируется, что все a(ij) равны либо нулю, либо единице.
    /// 
    /// Выходные данные
    /// Для каждого набора входных данных выведите в файл OUTPUT.TXT единственную строку, содержащую слово «YES», 
    /// если соответствующая таблица является симпатичной, и слово «NO» - в противном случае.
    /// </summary>
    public class Task0058
    {
        public static void Main()
        {
            GetInputData(out var inputSet);

            var result = Solve(inputSet);

            PrintResult(result);
        }

        private static void GetInputData(out Set[] inputSet)
        {
            var t = int.Parse(Console.ReadLine());

            inputSet = new Set[t];
            for (var i = 0; i < t; i++)
            {
                inputSet[i] = new Set();

                var input = Console.ReadLine().Split();
                inputSet[i].N = int.Parse(input[0]);
                inputSet[i].M = int.Parse(input[1]);

                inputSet[i].Matrix = new int[inputSet[i].N, inputSet[i].M];
                for (var k = 0; k < inputSet[i].N; k++)
                {
                    input = Console.ReadLine().Split();
                    for (var j = 0; j < inputSet[i].M; j++)
                    {
                        inputSet[i].Matrix[k, j] = int.Parse(input[j]);
                    }
                }
            }
        }

        public static string[] Solve(Set[] inputSet)
        {
            var result = new string[inputSet.Length];

            for (var k = 0; k < inputSet.Length; k++)
            {
                result[k] = "YES";
                var isContinue = false;
                for (var i = 0; i < inputSet[k].N - 1; i++)
                {
                    for (var j = 0; j < inputSet[k].M - 1; j++)
                    {
                        if (inputSet[k].Matrix[i, j] == 0 &&
                            inputSet[k].Matrix[i, j + 1] == 0 &&
                            inputSet[k].Matrix[i + 1, j] == 0 &&
                            inputSet[k].Matrix[i + 1, j + 1] == 0)
                        {
                            result[k] = "NO";
                            isContinue = true;
                            break;
                        }

                        if (inputSet[k].Matrix[i, j] == 1 &&
                            inputSet[k].Matrix[i, j + 1] == 1 &&
                            inputSet[k].Matrix[i + 1, j] == 1 &&
                            inputSet[k].Matrix[i + 1, j + 1] == 1)
                        {
                            result[k] = "NO";
                            isContinue = true;
                            break;
                        }
                    }

                    if (isContinue)
                        break;
                }
            }

            return result;
        }

        private static void PrintResult(string[] result)
        {
            Array.ForEach(result, x => Console.WriteLine(x));
        }

        public struct Set
        {
            public int N;
            public int M;
            public int[,] Matrix;
        }
    }
}
using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 88 - "Судоку"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 27%)
    /// 
    /// Судоку размера n называется квадрат со стороной n^2, разделенный на n^2 средних квадратов со стороной n,
    /// каждый из которых разделен на n^2 маленьких квадратов. В каждом маленьком квадрате записано число от 1 до n^2.
    ///
    /// Судоку называется правильным, если в каждом столбце, каждой строке и каждом среднем квадрате встречаются все числа от 1 до n^2.
    ///
    /// Недавно Вася нарисовал Судоку размера n. Ваша задача – помочь ему определить правильный ли он.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT содержится число n (1 ≤ n ≤ 10).
    /// В следующих n^2 строчках содержится по n^2 чисел, задающих нарисованный Васей Судоку.
    ///
    /// Все числа во входном файле натуральные и не превосходят 100 по модулю.
    /// 
    /// Выходные данные
    /// Если Судоку правильный, то выведите в выходной файл OUTPUT.TXT слово «Correct», иначе выведите «Incorrect».
    /// </summary>
    public static class Task0088 
    {
        public static void Main()
        {            
            GetInputData(out var n, out var field);

            var result = Solve(n, field);

            PrintResult(result);  
        }

        private static void GetInputData(out int n, out int[,] field)
        {
            n = int.Parse(Console.ReadLine());

            field = new int[n * n, n * n];
            for (var i = 0; i < n * n; i++)
            {
                var row = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (var j = 0; j < row.Length; j++)
                {
                    field[i, j] = int.Parse(row[j]);
                }
            }
        }

        public static string Solve(int n, int[,] field)
        {
            for (var i = 0; i < n * n; i++)
            {
                var array = new int[n * n];
                for (var j = 0; j < n * n; j++)
                {
                    if (field[i, j] > n * n)
                        return "Incorrect";
                    
                    array[field[i, j] - 1]++;
                    if (array[field[i, j] - 1] == 2)
                        return "Incorrect";
                }

                array = new int[n * n];
                for (var j = 0; j < n * n; j++)
                {
                    if (field[j, i] > n * n)
                        return "Incorrect";
                    
                    array[field[j, i] - 1]++;
                    if (array[field[j, i] - 1] == 2)
                        return "Incorrect";
                }
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var array = new int[n * n];
                    for (var y = i * n; y < (i + 1) * n; y++)
                    {
                        for (var x = j * n; x < (j + 1) * n; x++)
                        {
                            array[field[y, x] - 1]++;
                            if (array[field[y, x] - 1] == 2)
                                return "Incorrect";
                        }
                    }
                }
            }
            
            return "Correct";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
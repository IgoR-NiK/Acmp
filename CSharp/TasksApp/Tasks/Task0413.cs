using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 413 - "Военная база"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 32%)
    /// 
    /// Со спутника-шпиона получено изображение в некотором волновом диапазоне сверхсекретной военной базы предполагаемого противника.
    /// База расположена на Антарктиде, все постройки на ней высечены из кубов льда и имеют на фотографии квадратную форму
    /// и не имеют общих фрагментов стен ненулевой длины (по всей видимости, это сделано в целях маскировки от локаторов,
    /// работающих в инфракрасном спектре). Благодаря мастерству операторов оказалось, что стены разных построек параллельны границам фотографии.
    ///
    /// Для того, чтобы составить сверхсрочный отчет для командования, необходимо узнать, сколько зданий находятся на базе.
    /// Напишите программу, которая это сделает.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT записаны числа N и M (1 ≤ M, N ≤ 500) – размеры фотографии в пикселях по вертикали
    /// и по горизонтали. Следующие N строк содержат по M символов каждая: символ '.' соответствует пустому месту, '#' – элементу постройки.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите единственное число – количество построек на базе.
    /// </summary>
    public class Task0413
    {
        public static void Main()
        {
            GetInputData(out var field);

            var result = Solve(field);

            PrintResult(result);
        }

        private static void GetInputData(out int[,] field)
        {
            var input = Console.ReadLine();
            var n = int.Parse(input.Split()[0]);
            var m = int.Parse(input.Split()[1]);
  
            field = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                for (var j = 0; j < m; j++)
                {
                    switch (input.Substring(j, 1))
                    {
                        case ".": field[i, j] = 0; break;
                        case "#": field[i, j] = -1; break;
                    }
                }               
            }
        }

        public static int Solve(int[,] field)
        {
            var count = 0;
  
            for (var i = 0; i < field.GetLength(0); i++)
            {
                for (var j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == -1)
                    {
                        count++;
                        FillField(field, i, j, count);
                    }
                }
            }

            return count;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
        
        private static void FillField(int[,] field, int i, int j, int count)
        {
            var n = i;
            var m = j;
            
            while (m < field.GetLength(1) && field[i, m] == -1)
            {
                m++;
            }
            
            while (n < field.GetLength(0) && field[n, j] == -1)
            {
                n++;
            }
  
            for (var i1 = i; i1 < n; i1++)
            {
                for (var j1 = j; j1 < m; j1++)
                {
                    field[i1, j1] = count;
                }
            }
        }
    }
}
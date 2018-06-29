using System;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 27 - "Художник"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 26%)
    /// 
    /// Известный художник решил написать новый шедевр. После многих дней усердной работы он захотел исследовать свое творение. 
    /// Художник вспомнил, что картина писалась следующим образом: сначала был взят белый холст, имеющий форму прямоугольника шириной w и высотой h. 
    /// Затем художник нарисовал на этом холсте n прямоугольников со сторонами, параллельными сторонам холста и вершинами, 
    /// расположенными в целочисленных координатах. Помогите художнику определить площадь незакрашенной части холста.
    /// 
    /// Входные данные
    /// Первая строка входного файла INPUT.TXT содержит два натуральных числа w и h (1 ≤ w, h ≤ 100). 
    /// Во второй строке записано целое число n (0 ≤ n ≤ 5000) – количество прямоугольников. 
    /// Следующие n строк содержат информацию о всех прямоугольниках. Каждая строка описывает один прямоугольник в виде 
    /// четырех чисел x1, y1, x2, y2 , где (x1, y1) и (x2, y2) – координаты левого верхнего и правого нижнего угла прямоугольника соответственно.
    /// 
    /// Выходные данные
    /// Выведите в выходной файл OUTPUT.TXT одно целое число – площадь незакрашенной части холста.
    /// </summary>
    public class Task0027
    {
        public static void Main()
        {
            int w, h, n;
            Rectangle[] rectangles;
            GetInputData(out w, out h, out n, out rectangles);

            var result = Solve(w, h, n, rectangles);

            PrintResult(result);
        }

        private static void GetInputData(out int w, out int h, out int n, out Rectangle[] rectangles)
        {
            var input = Console.ReadLine().Split();

            w = int.Parse(input[0]);
            h = int.Parse(input[1]);

            n = int.Parse(Console.ReadLine());

            rectangles = new Rectangle[n];
            for (var i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                rectangles[i] = new Rectangle()
                {
                    LeftUp = new Point() { X = int.Parse(input[0]), Y = int.Parse(input[1]) },
                    RightDown = new Point() { X = int.Parse(input[2]), Y = int.Parse(input[3]) }
                };
            }
        }

        public static int Solve(int w, int h, int n, Rectangle[] rectangles)
        {
            var image = new int[w, h];
            
            for (var i = 0; i < n; i++)
            {
                for (var j = rectangles[i].LeftUp.X; j < rectangles[i].RightDown.X; j++)
                {
                    for (var k = rectangles[i].LeftUp.Y; k < rectangles[i].RightDown.Y; k++)
                    {
                        image[j, k] = 1;
                    }
                }
            }

            var s = 0;
            for (var i = 0; i < w; i++)
            {
                for (var j = 0; j < h; j++)
                {
                    if (image[i, j] == 0) s++;
                }
            }

            return s;  
        }

        private static void PrintResult(int result)
        {
            Console.Write(result);
        }

        public struct Point
        {
            public int X;
            public int Y;
        }

        public struct Rectangle
        {
            public Point LeftUp;
            public Point RightDown;
        }
    }    
}
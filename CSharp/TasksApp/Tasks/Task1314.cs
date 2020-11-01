using System;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1314 - "Упаковка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 26%)
	/// 
	/// В одну транспортную компанию поступил заказ на перевозку двух ящиков из одного города в другой.
	/// Для перевозки ящики решено было упаковать в специальный контейнер.
	///
	/// Ящики и контейнер имеют вид прямоугольных параллелепипедов. Длина, ширина и высота первого ящика – l(1), w(1) и h(1),
	/// соответствующие размеры второго ящика – l(2), w(2) и h(2). Контейнер имеет длину, ширину и высоту l(c), w(c) и h(c).
	///
	/// Поскольку ящики содержат хрупкое оборудование, после упаковки в контейнер каждый из них должен остаться
	/// в строго вертикальном положении. Таким образом, ящики можно разместить рядом или один на другом.
	/// Для надежного закрепления в контейнере стороны ящиков должны быть параллельны его сторонам.
	/// Иначе говоря, если исходно ящики были расположены так, что все их стороны параллельны соответствующим
	/// сторонам контейнера, то каждый из них разрешается перемещать
	/// и поворачивать относительно вертикальной оси на угол, кратный 90 градусам.
	///
	/// Разумеется, после упаковки оба ящика должны полностью находиться внутри контейнера и не должны пересекаться.
	///
	/// Выясните, можно ли поместить ящики в контейнер, с выполнением указанных условий.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит l(1), w(1) и h(1),
	/// вторая – l(2), w(2) и h(2),
	/// третья – l(c), w(c) и h(c).
	/// Все размеры – целые положительные числа, не превышающие 1000. Числа в строках разделены пробелами.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите YES, если ящики можно упаковать в контейнер и NO в противном случае.
	/// </summary>
	public static class Task1314
    {
        public static void Main()
        {            
            GetInputData(
	            out var l1, out var w1, out var h1,
	            out var l2, out var w2, out var h2,
	            out var lc, out var wc, out var hc);

            var result = Solve(l1, w1, h1, l2, w2, h2, lc, wc, hc);

            PrintResult(result);  
        }

        private static void GetInputData(
	        out int l1, out int w1, out int h1,
	        out int l2, out int w2, out int h2,
	        out int lc, out int wc, out int hc)
        {
	        var input1 = Console.ReadLine().Split();
	        var input2 = Console.ReadLine().Split();
	        var input3 = Console.ReadLine().Split();
 
	        l1 = int.Parse(input1[0]);
	        w1 = int.Parse(input1[1]);
	        h1 = int.Parse(input1[2]);
 
	        l2 = int.Parse(input2[0]);
	        w2 = int.Parse(input2[1]);
	        h2 = int.Parse(input2[2]);
 
	        lc = int.Parse(input3[0]);
	        wc = int.Parse(input3[1]);
	        hc = int.Parse(input3[2]);
        }

        public static string Solve(int l1, int w1, int h1, int l2, int w2, int h2, int lc, int wc, int hc)
        {
	        int MAXc, MINc, MAX1, MIN1, MAX2, MIN2;
	        if (w1 < l1)
	        {
		        MAX1 = l1;
		        MIN1 = w1;
	        }
	        else
	        {
		        MAX1 = w1;
		        MIN1 = l1;
	        }
	        if (w2 < l2)
	        {
		        MAX2 = l2;
		        MIN2 = w2;
	        }
	        else
	        {
		        MAX2 = w2;
		        MIN2 = l2;
	        }
	        if (wc < lc)
	        {
		        MAXc = lc;
		        MINc = wc;
	        }
	        else
	        {
		        MAXc = wc;
		        MINc = lc;
	        }
 
	        if (h1 > hc || h2 > hc)
	        {
		        return "NO";
	        }
	        
	        if (h1 + h2 <= hc)
	        {
		        return MIN1 <= MINc && MAX1 <= MAXc && MIN2 <= MINc && MAX2 <= MAXc ? "YES" : "NO";
	        }


	        return MIN1 + MIN2 <= MAXc && MAX1 <= MINc && MAX2 <= MINc ||
	               MIN1 + MIN2 <= MINc && MAX1 <= MAXc && MAX2 <= MAXc
		        ? "YES"
		        : "NO";
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
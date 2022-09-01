using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 504 - "Цветочки"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// В рождественский вечер на окошке стояло три цветочка, слева направо: герань, крокус и фиалка.
	/// Каждое утро Маша вытирала окошко и меняла местами стоящий справа цветок с центральным цветком.
	/// А Таня каждый вечер поливала цветочки и меняла местами левый и центральный цветок.
	/// Требуется определить порядок цветов ночью по прошествии K дней.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT содержится натуральное число K – число дней (K ≤ 1000).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT требуется вывести три английских буквы: «G», «C» и «V» (заглавные буквы без пробелов),
	/// описывающие порядок цветов на окошке по истечении K дней (слева направо).
	/// Обозначения: G – герань, C – крокус, V – фиалка.
	/// </summary>
	public static class Task0504
    {
        public static void Main()
        {            
            GetInputData(out var k);

            var result = Solve(k);

            PrintResult(result);  
        }

        private static void GetInputData(out int k)
        {
	        k = int.Parse(Console.ReadLine());
        }

        public static char[] Solve(int k)
        {
	        var result = new[] { 'G', 'C', 'V' };

	        for (var i = 0; i < k; i++)
	        {
		        Swap(result, 1, 2);
		        Swap(result, 0, 1);
	        }

	        return result;
        }

        private static void PrintResult(char[] result)
        {
	        for (var i = 0; i < result.Length; i++)
	        {
		        Console.Write(result[i]);
	        }
        }

        private static void Swap(char[] array, int index1, int index2)
        {
	        var temp = array[index1];
	        array[index1] = array[index2];
	        array[index2] = temp;
        }
    }
}
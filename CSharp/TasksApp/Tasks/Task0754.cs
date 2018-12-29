using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 754 - "Три толстяка"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 7%)
	/// 
	/// Три толстяка решили поспорить: кто из них самый тяжелый. После взвешивания оказалось, что их масса соответственно M1, M2 и M3 килограмм. Считается, что масса толстяка должна быть не менее 94 и не более 727 килограмм.
	///
	/// Помогите определить массу самого тяжелого из них, либо выяснить, что была допущена ошибка при взвешивании.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит три целых числа M1, M2 и M3, разделенные пробелом. Все числа целые и не превосходят 10 000 по абсолютной величине.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите массу самого тяжелого толстяка в случае корректного взвешивания, либо слово «Error» в противном случае.
	/// </summary>
	public static class Task0754
    {
        public static void Main()
        {            
            GetInputData(out var m1, out var m2, out var m3);

            var result = Solve(m1, m2, m3);

            PrintResult(result);  
        }

        private static void GetInputData(out int m1, out int m2, out int m3)
        {
            var inputData = Console.ReadLine().Split();
            m1 = int.Parse(inputData[0]);
            m2 = int.Parse(inputData[1]);
			m3 = int.Parse(inputData[2]);
		}

        public static string Solve(int m1, int m2, int m3)
        {
			return m1 < 94 || m1 > 727 || m2 < 94 || m2 > 727 || m3 < 94 || m3 > 727 ? "Error" : (m2 > m1) ? ((m2 > m3) ? $"{m2}" : $"{m3}") : ((m1 > m3) ? $"{m1}" : $"{m3}");
		}

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
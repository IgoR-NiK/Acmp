using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 131 - "Перепись"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
	/// 
	/// В доме живет N жильцов. Однажды решили провести перепись всех жильцов данного дома и составили список, 
	/// в котором указали возраст и пол каждого жильца. Требуется найти номер самого старшего жителя мужского пола.
	/// 
	/// Входные данные
	/// Во входном файле INPUT.TXT в первой строке задано натуральное число N – количество жильцов (N ≤ 100). 
	/// В последующих N строках располагается информация о всех жильцах: каждая строка содержит два целых числа: 
	/// V и S – возраст и пол человека (1 ≤ V ≤ 100, S – 0 или 1). Мужскому полу соответствует значение S=1, а женскому – S=0.
	/// 
	/// Выходные данные
	/// Выходной файл OUTPUT.TXT должен содержать номер самого старшего мужчины в списке. 
	/// Если таких жильцов несколько, то следует вывести наименьший номер. Если жильцов мужского пола нет, то выведите -1.
	/// </summary>
	public class Task0131
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out Person[] input)
        {
			var n = int.Parse(Console.ReadLine());

			input = new Person[n];
			for (var i = 0; i < n; i++)
			{
				var person = Console.ReadLine().Split();
				input[i] = new Person()
				{
					Age = int.Parse(person[0]),
					Gender = int.Parse(person[1])
				};
			}
        }

        public static int Solve(Person[] input)
        {
			var max = -1;
			var maxIndex = -2;

			for (var i = 0; i < input.Length; i++)
			{
				if (input[i].Gender == 1 && input[i].Age > max)
				{
					max = input[i].Age;
					maxIndex = i;
				}
			}

			return maxIndex + 1;
        }

        private static void PrintResult(int result)
        {
			Console.Write(result);
        }

		public class Person
		{
			public int Age { get; set; }
			public int Gender { get; set; }
		}
	}
}
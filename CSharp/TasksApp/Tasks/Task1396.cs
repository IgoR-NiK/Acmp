using System;
using System.Text;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1396 - "Призы"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 19%)
	/// 
	/// Петр участвует в конкурсе, в котором разыгрывается n призов. Призы пронумерованы от 1 до n.
	///
	/// По итогам конкурса участник может набрать от 2 до n баллов. Если участник наберет k баллов, то он получит
	/// один из призов с номером от 1 до k. Перед тем, как участник выберет свой приз, ведущий конкурса удаляет
	/// один из призов из списка. Затем участник может выбрать любой приз из оставшихся k-1.
	///
	/// Список призов стал известен Петру. Он определил для каждого приза его ценность, для i-го приза она задается целым числом a(i).
	///
	/// Требуется написать программу, которая по заданным ценностям призов определяет для каждого k от 2 до n,
	/// приз с какой максимальной ценностью гарантированно достанется Петру, если он наберет в конкурсе k баллов.
	/// 
	/// Входные данные
	/// Первая строка входного файла INPUT.TXT содержит число n (2 ≤ n ≤ 100 000).
	/// Вторая строка этого файла содержит n целых чисел: a(1), a(2), …, a(n) (1 ≤ a(i) ≤ 10^9).
	/// 
	/// Выходные данные
	/// Выходной файл OUTPUT.TXT должен содержать одну строку, содержащую n-1 целых чисел: для каждого k от 2 до n
	/// должна быть выведена ценность приза, который достанется Петру, если он наберет k баллов.
	/// </summary>
	public static class Task1396
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);  
        }

        private static void GetInputData(out int[] input)
        {
	        var n = int.Parse(Console.ReadLine());
	        
	        input = new int[n];
	        
	        var index = 0;
            var number = new StringBuilder();
            while (true)
            {
                var ch = Console.Read();
                if (ch != -1 && Char.IsDigit((char)ch))
                {
                    number.Append((char)ch);
                    continue;
                }
                
                if (int.TryParse(number.ToString(), out var num))
                {
                    if (index < n)
                    {
                        input[index] = num;
                    }
                    else
                    {
                        break;
                    }

                    number.Clear();
                    index++;
                }
                else
                {
                    if (index < n)
                    {
                        continue;
                    }
                    
                    break;
                }
            }
        }

        public static int[] Solve(int[] input)
        {
	        var n = input.Length;
	        var result = new int[n - 1];

	        var max = input[0];
	        var afterMax = input[1];
	        for (var i = 0; i < n - 1; i++) 
	        {       
		        if (input[i + 1] >= max)
		        {
			        afterMax = max;
			        max = input[i + 1];
		        }
		        if (input[i + 1] > afterMax && input[i + 1] != max)
		        {
			        afterMax = input[i + 1];
		        }

		        result[i] = afterMax;
	        }

	        return result;
        }

        private static void PrintResult(int[] result)
        {
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
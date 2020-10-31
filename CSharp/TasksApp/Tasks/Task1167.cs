using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1167 - "Формула"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 43%)
	/// 
	/// ОЗадана формула следующего вида:
	///
	/// <формула> ::=<цифра>|M(<формула>,<формула>)|m(<формула>,<формула>)
	/// <цифра> ::= 0|1|2|3|4|5|6|7|8|9
	/// где М обозначает функцию max – максимальный элемент, m обозначает функцию min – минимальный элемент, | - знак «или».
	///
	/// Требуется вычислить значение по данной формуле.
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит формулу в указанном формате без ошибок (непустую строку, состоящую не более чем из 1000 символов).
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите цифру – значение данной формулы.
	/// </summary>
	public static class Task1167
    {
        public static void Main()
        {            
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);  
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();
        }

        public static int Solve(string input)
        {
	        if (char.IsDigit(input[0]))
	        {
		        return input[0] - '0';
	        }
	        
	        if (input[0] == 'M')
	        {
		        input = input.Substring(2, input.Length - 3);
		        var p = Params(input);
		        return Math.Max(Solve(p[0]), Solve(p[1]));
	        }
	        else
	        {
		        input = input.Substring(2, input.Length - 3);
		        var p = Params(input);
		        return Math.Min(Solve(p[0]), Solve(p[1]));
	        }
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
        
        private static string[] Params(string s)
        {
	        var k1 = 0;
	        var k2 = 0;
	        var number = 0;
	        for (var i = 0; i < s.Length; i++)
	        {
		        if (s[i] == ',' && k1 == k2)
		        {
			        number = i;
			        break;
		        }
		        
		        if (s[i] == '(')
		        {
			        k1++;
		        }
		        else if (s[i] == ')')
		        {
			        k2++;
		        }
	        }

	        return new[] { s.Substring(0, number), s.Substring(number + 1) };
        }
    }
}
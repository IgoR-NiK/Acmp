using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 173 - "Число - палиндром"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 29%)
	/// 
	/// Напомним, что палиндромом называется строка, одинаково читающаяся с обеих сторон.
	/// Например, строка «ABBA» является палиндромом, а строка «ABC» - нет.
	///
	/// Необходимо определить, в каких системах счисления с основанием от 2 до 36 представление заданного числа N является палиндромом.
	///
	/// В системах счисления с основанием большим 10 в качестве цифр используются буквы английского алфавита: A, B, ... , Z.
	/// Например, A(11) = 10(10), Z(36) = 35(10).
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит заданное число N в десятичной системе счисления (1 ≤ N ≤ 10^9).
	/// 
	/// Выходные данные
	/// Если соответствующее основание системы счисления определяется единственным образом,
	/// то выведите в первой строке выходного файла OUTPUT.TXT слово «unique»,
	/// если оно не единственно — выведите в первой строке выходного файла слово «multiple».
	/// Если же такого основания системы счисления не существует — выведите в первой строке выходного файла слово «none».
	///
	/// В случае существования хотя бы одного требуемого основания системы счисления выведите через пробел
	/// в возрастающем порядке во второй строке выходного файла все основания системы счисления, удовлетворяющие требованиям.
	/// </summary>
	public class Task0173
    {
        public static void Main()
        {            
            GetInputData(out var n);
						
			var result = Solve(n);

            PrintResult(result);
        }

        private static void GetInputData(out int n)
        {
	        n = int.Parse(Console.ReadLine());
        }

        public static List<int> Solve(int n)
        {
	        var result = new List<int>();
	        
	        for (var i = 2; i <= 36; i++)
	        {
		        var fromDec = FromDec(n, i);

		        var isNext = false;
		        for (var j = 0; j < fromDec.Length; j++)
		        {
			        if (fromDec[j] != fromDec[fromDec.Length - 1 - j])
			        {
				        isNext = true;
				        break;
			        }
		        }

		        if (isNext)
		        {
			        continue;
		        }

		        result.Add(i);
	        }

	        return result;
        }

        private static void PrintResult(List<int> result)
        {
	        switch (result.Count)
	        {
		        case 0:
			        Console.WriteLine("none");
			        break;
		        case 1:
			        Console.WriteLine("unique");
			        Console.WriteLine(result[0]);
			        break;
		        default:
			        Console.WriteLine("multiple");
			        Console.WriteLine(string.Join(" ", result));
			        break;
	        }
        }
        
        private static string FromDec(int n, int p)
        {
	        var result = "";

	        for (; n > 0; n /= p)
	        {
		        var x = n % p;
		        result = (char)(x < 0 || x > 9 ? x + 'A' - 10 : x + '0') + result;
	        }
	        
	        return result;
        }
    }
}
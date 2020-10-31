using System;

namespace TasksApp.Tasks
{
	/// <summary>
	/// Задача 1038 - "Перевязь"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 12%)
	/// 
	/// Портос хочет украсить золотым шитьем свою перевязь. Он знает, что один сантиметр золотого шитья стоит один луидор.
	/// Портосу надо вышить N миллиметров перевязи. Причем мастер никогда не возьмется за работу,
	/// если ему заплатят меньше, чем стоит работа. И сдачу мастер никогда не отдает.
	///
	/// Какое минимальное количество луидоров Портос должен заплатить мастеру за работу?
	/// 
	/// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число N (N ≤ 10^9) – длина перевязи в миллиметрах.
	/// 
	/// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите минимальное количество луидоров, которые Портос должен отдать за работу.
	/// </summary>
	public static class Task1038
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

        public static int Solve(int n)
        {
	       return (int)Math.Ceiling(n / 10.0);
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
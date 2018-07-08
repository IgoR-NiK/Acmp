﻿using System;

namespace TasksApp.Tasks
{
    /// <summary>
	/// Задача 942 - "Олимпиада"
	/// (Время: 1 сек. Память: 16 Мб Сложность: 2%)
    /// 
    /// Трое студентов, пятикурсник, третьекурсник и первокурсник, живут в одной комнате общежития и любят участвовать в соревнованиях по программированию по правилам ACM. 
	/// У каждого из них свой подход к решению задач. Пятикурсник решает все задачи строго по порядку - сначала первую, затем вторую, и так до последней. 
	/// Третьекурсник решает задачи строго в обратном порядке – сначала последнюю, затем предпоследнюю, и так до первой. 
	/// А первокурсник сначала решает самую простую задачу, затем – самую простую из оставшихся задач, и так до самой сложной. 
	/// Сложность задачи определяется временем, необходимым для её решения. Для решения одной и той же задачи наши студенты тратят одинаковое количество времени.
	///
	/// Ваша задача – по описанию соревнований по программированию определить, кто из студентов победит. 
	/// Напомним, что по правилам ACM побеждает участник, за 300 минут решивший больше всего задач, а при равенстве количества задач – набравший меньше штрафного времени.
	/// 
	/// Наши студенты – очень сильные программисты, и при решении задач они не делают неправильных попыток. 
	/// Поэтому за задачу начисляется штраф в размере количества минут от начала соревнования до её посылки на проверку. 
	/// Если же и количество штрафного времени совпадает – то студент со старшего курса уступает победу студенту с младшего курса.
    /// 
    /// Входные данные
	/// Входной файл INPUT.TXT содержит натуральное число N (N ≤ 10) – количество задач. 
	/// Во второй строке записаны N натуральных чисел – количество минут, необходимое для решения каждой задачи. Время решения задачи не превосходит 300 минут.
    /// 
    /// Выходные данные
	/// В выходной файл OUTPUT.TXT выведите номер курса студента, одержавшего победу в олимпиаде.
    /// </summary>
	public class Task0942
	{
		public static void Main()
		{
			int[] tasks;
			GetInputData(out tasks);

			var result = Solve(tasks);

			PrintResult(result);
		}

		private static void GetInputData(out int[] tasks)
		{
			var n = int.Parse(Console.ReadLine());
			string[] input = Console.ReadLine().Split();

			tasks = new int[n];
			for (var i = 0; i < n; i++)
			{
				tasks[i] = int.Parse(input[i]);
			}
		}

		public static int Solve(int[] tasks)
		{
			return 1;
		}

		private static void PrintResult(int result)
		{
			Console.WriteLine(result);
		}
	}
}
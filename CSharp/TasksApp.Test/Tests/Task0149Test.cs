﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0149Test
	{
		private static void CheckTest(string[] input, string[] result)
		{
			var resultTest = Task0149.Solve(input);
			for (var i = 0; i < result.Length; i++)
			{
				Assert.That(result[i], Is.EqualTo(resultTest[i]));
			}
			
		}

		[Test]
		public void Test1()
		{
			CheckTest(new[] { "1", "2", "3" }, new[] { "3", "2", "1" });
		}		
	}
}
using System;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0173Test
	{
		private static void CheckTest(int n, int[] expected)
		{
			var actual = Task0173.Solve(n);
			Assert.AreEqual(expected.Length, actual.Count);

			for (var i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], actual[i]);
			}
		}

		[Test]
		public void Test1()
		{
			CheckTest(123, new[] { 6 });
		}

		[Test]
		public void Test2()
		{
			CheckTest(111, new[] { 6, 10, 36 });
		}
		
		[Test]
		public void Test3()
		{
			CheckTest(102892748, Array.Empty<int>());
		}
	}
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0121Test
	{
		private static void CheckTest(int[] input, int result)
		{
			var resultTest = Task0121.Solve(input);
			Assert.That(result, Is.EqualTo(resultTest));
		}

		[Test]
		public void Test1()
		{
			CheckTest(new[] { 3, 4, 12, 6, 14, 13 }, 5);
		}

		[Test]
		public void Test2()
		{
			CheckTest(new[] { 10, 3, 7, 19, 20, 21 }, 9);
		}

		[Test]
		public void Test3()
		{
			CheckTest(new[] { 3, 7, 10, 15, 20, 21 }, 10);
		}

		[Test]
		public void Test4()
		{
			CheckTest(new[] { 2, 3, 6, 8, 9, 12, 15 }, 7);
		}

		[Test]
		public void Test5()
		{
			CheckTest(new[] { 682, 2517, 2478, 2816, 4980, 5839, 6414, 7667, 8802, 8995 }, 4400);
		}

		[Test]
		public void Test6()
		{
			CheckTest(new[] { 593, 716, 845, 603, 858, 545, 848, 424, 624, 646, 385, 438, 298, 892, 57, 964, 273, 384, 478, 792, 813, 529, 480, 569, 393, 926, 837, 72, 338 }, 340);
		}

		[Test]
		public void Test7()
		{
			CheckTest(new[] { 69, 73 }, 4);
		}

		[Test]
		public void Test8()
		{
			CheckTest(new[] { 123, 69, 73 }, 54);
		}

		[Test]
		public void Test9()
		{
			CheckTest(new[] { 1, 2, 15, 17 }, 3);
		}

		[Test]
		public void Test10()
		{
			CheckTest(new[] { 1, 2, 10, 15, 17 }, 8);
		}

		[Test]
		public void Test11()
		{
			CheckTest(new[] { 0, 1000 }, 1000);
		}

		[Test]
		public void Test12()
		{
			CheckTest(new[] { 10, 100 }, 90);
		}
	}
}
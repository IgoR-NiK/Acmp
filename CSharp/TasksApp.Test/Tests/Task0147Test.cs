using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0147Test
	{
		private static void CheckTest(int n, int result)
		{
			var resultTest = Task0147.Solve(n);
			Assert.AreEqual(resultTest, result);
		}

		[Test]
		public void Test1()
		{
			CheckTest(7, 13);
		}

		[Test]
		public void Test2()
		{
			CheckTest(0, 0);
		}

		[Test]
		public void Test3()
		{
			CheckTest(1, 1);
		}

		[Test]
		public void Test4()
		{
			CheckTest(2, 1);
		}

		[Test]
		public void Test5()
		{
			CheckTest(11, 89);
		}

		[Test]
		public void Test6()
		{
			CheckTest(30, 832040);
		}
	}
}
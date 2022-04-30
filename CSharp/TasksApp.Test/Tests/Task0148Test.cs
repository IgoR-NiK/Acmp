using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0148Test
	{
		private static void CheckTest(int a, int b, int result)
		{
			var resultTest = Task0148.Solve(a, b);
			Assert.AreEqual(result, resultTest);
		}

		[Test]
		public void Test1()
		{
			CheckTest(12, 42, 6);
		}
	}
}
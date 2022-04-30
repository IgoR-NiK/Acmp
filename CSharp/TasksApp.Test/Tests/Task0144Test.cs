using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0144Test
	{
		private static void CheckTest(Task0144.BigInteger a, int b, string result)
		{
			var resultTest = Task0144.Solve(a, b);
			Assert.AreEqual(resultTest.ToString(), result);
		}

		[Test]
		public void Test1()
		{
			CheckTest(new Task0144.BigInteger("5"), 7, "35");
		}
	}
}
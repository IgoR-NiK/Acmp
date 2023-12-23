using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0145Test
	{
		private static void CheckTest(Task0145.BigInteger a, int b, string result)
		{
			var resultTest = Task0145.Solve(a, b);
			Assert.That(resultTest.ToString(), Is.EqualTo(result));
		}

		[Test]
		public void Test1()
		{
			CheckTest(new Task0145.BigInteger("7"), 3, "2");
		}
	}
}
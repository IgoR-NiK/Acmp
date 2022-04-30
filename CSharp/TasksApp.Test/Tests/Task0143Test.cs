using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0143Test
	{
		private static void CheckTest(Task0143.BigInteger a, Task0143.BigInteger b, string result)
		{
			var resultTest = Task0143.Solve(a, b);
			Assert.AreEqual(resultTest.ToString(), result);
		}

		[Test]
		public void Test1()
		{
			CheckTest(new Task0143.BigInteger("7"), new Task0143.BigInteger("5"), "2");
		}

		[Test]
		public void Test2()
		{			
			CheckTest(new Task0143.BigInteger("5"), new Task0143.BigInteger("17"), "-12");
		}
	}
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestClass]
	public class Task0145Test
	{
		private void CheckTest(Task0145.BigInteger a, int b, string result)
		{
			var resultTest = Task0145.Solve(a, b);
			Assert.AreEqual(resultTest.ToString(), result);
		}

		[TestMethod]
		public void Test1()
		{
			CheckTest(new Task0145.BigInteger("7"), 3, "2");
		}
	}
}
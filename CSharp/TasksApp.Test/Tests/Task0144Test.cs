using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestClass]
	public class Task0144Test
	{
		private void CheckTest(Task0144.BigInteger a, int b, string result)
		{
			var resultTest = Task0144.Solve(a, b);
			Assert.AreEqual(resultTest.ToString(), result);
		}

		[TestMethod]
		public void Test1()
		{
			CheckTest(new Task0144.BigInteger("5"), 7, "35");
		}
	}
}
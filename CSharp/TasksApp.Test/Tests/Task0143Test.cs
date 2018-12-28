using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestClass]
	public class Task0143Test
	{
		private void CheckTest(Task0143.BigInteger a, Task0143.BigInteger b, string result)
		{
			var resultTest = Task0143.Solve(a, b);
			Assert.AreEqual(resultTest.ToString(), result);
		}

		[TestMethod]
		public void Test1()
		{
			CheckTest(new Task0143.BigInteger("7"), new Task0143.BigInteger("5"), "2");
		}

		[TestMethod]
		public void Test2()
		{			
			CheckTest(new Task0143.BigInteger("5"), new Task0143.BigInteger("17"), "-12");
		}
	}
}
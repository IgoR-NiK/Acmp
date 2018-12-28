using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestClass]
	public class Task0147Test
	{
		private void CheckTest(int n, int result)
		{
			var resultTest = Task0147.Solve(n);
			Assert.AreEqual(resultTest, result);
		}

		[TestMethod]
		public void Test1()
		{
			CheckTest(7, 13);
		}

		[TestMethod]
		public void Test2()
		{
			CheckTest(0, 0);
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(1, 1);
		}

		[TestMethod]
		public void Test4()
		{
			CheckTest(2, 1);
		}

		[TestMethod]
		public void Test5()
		{
			CheckTest(11, 89);
		}

		[TestMethod]
		public void Test6()
		{
			CheckTest(30, 832040);
		}
	}
}
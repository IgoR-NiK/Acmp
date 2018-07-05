using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0970Test
    {
        private void CheckTest(int a1, int a2, int a3, string result)
        {
            var test = Task0970.Solve(a1, a2, a3);
			Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(3, 5, 2, "YES");
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(2, 2, 5, "NO");
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(2, 2, 4, "YES");
		}
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0766Test
    {
        private void CheckTest(int n, int m, int k, string result)
        {
            var resultTest = Task0766.Solve(n, m, k);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(4, 5, 20, "YES");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(4, 5, 21, "NO");
        }

		[TestMethod]
		public void Test3()
		{
			CheckTest(3, 2, 1, "YES");
		}
	}
}

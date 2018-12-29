using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0692Test
    {
        private void CheckTest(int n, string result)
        {
            var resultTest = Task0692.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(1024, "YES");
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(1000, "NO");
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(23, "NO");
		}
	}
}

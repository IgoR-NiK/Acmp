using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0539Test
    {
        private void CheckTest(int n, int result)
        {
            var resultTest = Task0539.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(2, 1);
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(1, 0);
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(3, 3);
		}
	}
}

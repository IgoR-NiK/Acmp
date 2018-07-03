using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0036Test
    {
        private void CheckTest(int n, int result)
        {
            var test = Task0036.Solve(n);
			Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(2, 1);
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(239, 39);
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(3000, 353);
		}
    }
}
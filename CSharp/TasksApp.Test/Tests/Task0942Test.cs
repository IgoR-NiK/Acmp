using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0942Test
    {
        private void CheckTest(int[] tasks, int result)
        {
            var test = Task0942.Solve(tasks);
			Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(new[] { 40, 30, 60 }, 1);
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(new[] { 10, 20, 30, 40 }, 1);
		}
    }
}
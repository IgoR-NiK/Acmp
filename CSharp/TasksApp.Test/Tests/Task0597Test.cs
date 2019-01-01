using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0597Test
    {
        private void CheckTest(int r1, int r2, int r3, string result)
        {
            var resultTest = Task0597.Solve(r1, r2, r3);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(10, 10, 10, "NO");
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(10, 3, 4, "YES");
		}
	}
}

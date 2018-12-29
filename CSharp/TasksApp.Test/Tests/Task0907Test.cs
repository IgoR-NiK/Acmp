using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0907Test
    {
        private void CheckTest(int w, int h, int r, string result)
        {
            var resultTest = Task0907.Solve(w, h, r);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(4, 7, 2, "YES");
        }

        [TestMethod]
        public void Test2()
        {
			CheckTest(4, 7, 3, "NO");
		}
    }
}

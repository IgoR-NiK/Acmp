using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0052Test
    {
        private void CheckTest(int n, string result)
        {
            var test = Task0052.Solve(n);
			Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(385916, "YES");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(123456, "NO");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(9450, "YES");
        }

        [TestMethod]
        public void Test4()
        {
            CheckTest(1, "NO");
        }
    }
}
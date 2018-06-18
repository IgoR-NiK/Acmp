using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0011Test
    {
        private void CheckTest(int k, int n, string output)
        {
            var test = Task0011.Solve(k, n);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(1, 3, "1");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(2, 7, "21");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(3, 10, "274");
        }
    }
}
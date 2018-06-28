using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0021Test
    {
        private void CheckTest(int a, int b, int c, int output)
        {
            var test = Task0021.Solve(a, b, c);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(100, 500, 1000, 900);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(36, 11, 20, 25);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0022Test
    {
        private void CheckTest(int n, int output)
        {
            var test = Task0022.Solve(n);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, 2);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(7, 3);
        }
    }
}
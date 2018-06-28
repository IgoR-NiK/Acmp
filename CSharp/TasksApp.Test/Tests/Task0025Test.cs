using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0025Test
    {
        private void CheckTest(int a, int b, char output)
        {
            var test = Task0025.Solve(a, b);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, 7, '<');
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(-7, -12, '>');
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(13, 13, '=');
        }
    }
}
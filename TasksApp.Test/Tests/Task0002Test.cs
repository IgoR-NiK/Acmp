using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0002Test
    {
        private void CheckTest(int n, long result)
        {
            var resultTest = Task0002.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, 15);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(9, 45);
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(-4, -9);
        }
    }
}

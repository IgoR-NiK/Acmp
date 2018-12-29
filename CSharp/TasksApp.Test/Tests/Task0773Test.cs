using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0773Test
    {
        private void CheckTest(int k, int m, int result)
        {
            var resultTest = Task0773.Solve(k, m);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(2, 2, 8);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(12, 4, 576);
        }
    }
}

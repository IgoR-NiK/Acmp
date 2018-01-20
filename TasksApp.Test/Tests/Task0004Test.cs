using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0004Test
    {
        private void CheckTest(int k, string result)
        {
            var resultTest = Task0004.Solve(k);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, "594");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(2, "297");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(7, "792");
        }
    }
}

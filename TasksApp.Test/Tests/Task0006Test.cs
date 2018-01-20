using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0006Test
    {
        private void CheckTest(string input, string result)
        {
            var resultTest = Task0006.Solve(input);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("C7-D5", "YES");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest("E2-E4", "NO");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest("BSN", "ERROR");
        }
    }
}
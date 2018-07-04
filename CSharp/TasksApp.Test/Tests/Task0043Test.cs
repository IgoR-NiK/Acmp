using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0043Test
    {
        private void CheckTest(string input, int result)
        {
            var test = Task0043.Solve(input);
			Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest("00101110000110", 4);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest("00", 2);
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest("111", 0);
        }
    }
}
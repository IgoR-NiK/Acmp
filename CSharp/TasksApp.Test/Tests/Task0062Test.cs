using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0062Test
    {
        private void CheckTest(string input, string result)
        {
            var resultTest = Task0062.Solve(input);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("C3", "BLACK");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest("G8", "WHITE");
        }
    }
}
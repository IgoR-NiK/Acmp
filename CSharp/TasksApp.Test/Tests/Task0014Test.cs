using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0014Test
    {
        private void CheckTest(int a, int b, int output)
        {
            var test = Task0014.Solve(a, b);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(36, 27, 108);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(39, 65, 195);
        }
    }
}
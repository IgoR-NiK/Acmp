using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0325Test
    {
        private void CheckTest(string firstCoordinate, string secondCoordinate, string output)
        {
            var test = Task0325.Solve(firstCoordinate, secondCoordinate);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("a1", "h8", "NO");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest("a1", "b3", "1");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest("a1", "d4", "2");
        }

        [TestMethod]
        public void Test4()
        {
            CheckTest("c4", "c4", "2");
        }
    }
}

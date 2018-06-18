using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0001Test
    {
        private void CheckTest(int a, int b, int result)
        {
            var resultTest = Task0001.Solve(a, b);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(2, 3, 5);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(8, 9, 17);
        }
    }
}

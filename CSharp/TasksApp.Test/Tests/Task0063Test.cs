using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0063Test
    {
        private void CheckTest(int S, int P, Task0063.Result result)
        {
            var resultTest = Task0063.Solve(S, P);
            Assert.AreEqual(resultTest.X, result.X);
            Assert.AreEqual(resultTest.Y, result.Y);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(4, 4, new Task0063.Result() { X = 2, Y = 2 });
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(5, 6, new Task0063.Result() { X = 2, Y = 3 });
        }
    }
}
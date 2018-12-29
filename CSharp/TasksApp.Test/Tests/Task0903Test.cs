using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0903Test
    {
        private void CheckTest(int n, int result)
        {
            var resultTest = Task0903.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(3, 4);
        }
    }
}

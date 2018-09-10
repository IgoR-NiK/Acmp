using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0108Test
    {
        private void CheckTest(int input, int result)
        {
            var resultTest = Task0108.Solve(input);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, 5);
        }
    }
}

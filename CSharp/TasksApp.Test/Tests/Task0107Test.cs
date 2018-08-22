using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0107Test
    {
        private void CheckTest(string input, Task0107.Result result)
        {
            var resultTest = Task0107.Solve(input);
            Assert.AreEqual(resultTest.Number, result.Number);
            Assert.AreEqual(resultTest.Weight, result.Weight);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("8727333", new Task0107.Result() { Number = "8727-333", Weight = 5});
            }

        [TestMethod]
        public void Test2()
        {
            CheckTest("8827291", new Task0107.Result() { Number = "88-272-91", Weight = 4});
            }
    }
}
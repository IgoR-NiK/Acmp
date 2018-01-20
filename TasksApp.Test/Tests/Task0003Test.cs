using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0003Test
    {
        private void CheckTest(int a, long result)
        {
            var resultTest = Task0003.Solve(a);
            Assert.AreEqual(resultTest, result);                 
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, 25);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(75, 5625);
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(4255, 18105025);
        }
    }
}

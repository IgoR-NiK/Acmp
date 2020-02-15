using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0006Test
    {
        private void CheckTest(string input, string output)
        {
            var test = Task0006.Solve(input);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest("C7-D5", "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest("E2-E4", "NO");
        }

        [Test]
        public void Test3()
        {
            CheckTest("BSN", "ERROR");
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0233Test
    {
        private void CheckTest(int n, int[] heights, string result)
        {
            var solution = Task0233.Solve(n, heights);
            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, new[] { 763 }, "No crash");
        }

        [Test]
        public void Test2()
        {
            CheckTest(3, new[] { 763, 245, 113 }, "Crash 2");
        }

        [Test]
        public void Test3()
        {
            CheckTest(1, new[] { 437 }, "Crash 1");
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0277Test
    {
        private void CheckTest(int a, int b, int c, string result)
        {
            var solution = Task0277.Solve(a, b, c);

            Assert.AreEqual(solution, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(0, 2, -1, "2x-y");
        }

        [Test]
        public void Test2()
        {
            CheckTest(3, 0, -2, "3-2y");
        }
    }
}
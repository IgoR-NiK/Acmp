using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0026Test
    {
        private static void CheckTest(int x1, int y1, int r1, int x2, int y2, int r2, string output)
        {
            var test = Task0026.Solve(x1, y1, r1, x2, y2, r2);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest(0, 0, 2, 0, 3, 2, "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest(1, 1, 1, 4, 4, 1, "NO");
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0021Test
    {
        private static void CheckTest(int a, int b, int c, int output)
        {
            var test = Task0021.Solve(a, b, c);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest(100, 500, 1000, 900);
        }

        [Test]
        public void Test2()
        {
            CheckTest(36, 11, 20, 25);
        }
    }
}
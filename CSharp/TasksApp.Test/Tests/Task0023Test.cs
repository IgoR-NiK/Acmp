using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0023Test
    {
        private static void CheckTest(int n, int output)
        {
            var test = Task0023.Solve(n);
            Assert.That(test, Is.EqualTo(output));
        }

        [Test]
        public void Test1()
        {
            CheckTest(6, 12);
        }

        [Test]
        public void Test2()
        {
            CheckTest(10, 18);
        }
    }
}
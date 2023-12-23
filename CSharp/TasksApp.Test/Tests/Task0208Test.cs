using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0208Test
    {
        private static void CheckTest(int n, int result)
        {
            var solution = Task0208.Solve(n);
            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void Test1()
        {
            CheckTest(19, 28);
        }

        [Test]
        public void Test2()
        {
            CheckTest(1212, 1938);
        }
    }
}
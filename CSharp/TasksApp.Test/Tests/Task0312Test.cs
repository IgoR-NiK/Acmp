using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0312Test
    {
        private static void CheckTest(int a1, int a2, int n, int result)
        {
            var solution = Task0312.Solve(a1, a2, n);

            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, 5, 3, 9);
        }
    }
}
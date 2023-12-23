using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0296Test
    {
        private static void CheckTest(int n, Task0296.Result result)
        {
            var solution = Task0296.Solve(n);

            Assert.That(solution.Basilio, Is.EqualTo(result.Basilio));
            Assert.That(solution.Alisa, Is.EqualTo(result.Alisa));
        }

        [Test]
        public void Test1()
        {
            CheckTest(8, new Task0296.Result(1, 1));
        }

        [Test]
        public void Test2()
        {
            CheckTest(11, new Task0296.Result(1, 2));
        }

        [Test]
        public void Test3()
        {
            CheckTest(15, new Task0296.Result(3, 0));
        }
    }
}
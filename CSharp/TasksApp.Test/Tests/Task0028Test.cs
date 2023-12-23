using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0028Test
    {
        private static void CheckTest(Task0028.Line line, Task0028.Point a, Task0028.Point actual)
        {
            var test = Task0028.Solve(line, a);
            Assert.That(test, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            var line = new Task0028.Line(
                new Task0028.Point(0, 0), 
                new Task0028.Point(0, 1));

            CheckTest(line, new Task0028.Point(10, 10), new Task0028.Point(-10, 10));
        }

        [Test]
        public void Test2()
        {
            var line = new Task0028.Line(
                new Task0028.Point(0, 0),
                new Task0028.Point(1, 0));

            CheckTest(line, new Task0028.Point(10, 10), new Task0028.Point(10, -10));
        }
    }
}
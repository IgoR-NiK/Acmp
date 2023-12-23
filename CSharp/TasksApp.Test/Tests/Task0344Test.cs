using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0344Test
    {
        private static void CheckTest(Task0344.Point[] points, Task0344.Result result)
        {
            var actual = Task0344.Solve(points);
            
            Assert.That(result.Distance, Is.EqualTo(actual.Distance));
            Assert.That(result.Point1.Number, Is.EqualTo(actual.Point1.Number));
            Assert.That(result.Point2.Number, Is.EqualTo(actual.Point2.Number));
        }

        [Test]
        public void Test1()
        {
            var p1 = new Task0344.Point(1, 10);
            var p2 = new Task0344.Point(2, 3);
            var p3 = new Task0344.Point(3, 6);
            var p4 = new Task0344.Point(4, 2);
            var p5 = new Task0344.Point(5, 5);

            CheckTest(new[] { p1, p2, p3, p4, p5 }, new Task0344.Result { Point1 = p4, Point2 = p2 });
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0102Test
    {
        private void CheckTest(Task0102.Point[] points, string result)
        {
            var resultTest = Task0102.Solve(points);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[]{
                new Task0102.Point() { X = 0, Y = 0 },
                new Task0102.Point() { X = 100, Y = 0 },
                new Task0102.Point() { X = 0, Y = 100 },
                new Task0102.Point() { X = 100, Y = 100 } }, "Out");
        }

        [Test]
        public void Test2()
        {
            CheckTest(new[]{
                new Task0102.Point() { X = 0, Y = 0 },
                new Task0102.Point() { X = 100, Y = 0 },
                new Task0102.Point() { X = 0, Y = 100 },
                new Task0102.Point() { X = 10, Y = 10 } }, "In");
        }

        [Test]
        public void Test3()
        {
            CheckTest(new[]{
                new Task0102.Point() { X = 0, Y = 0 },
                new Task0102.Point() { X = 100, Y = 0 },
                new Task0102.Point() { X = 0, Y = 100 },
                new Task0102.Point() { X = 50, Y = 50 } }, "In");
        }

        [Test]
        public void Test4()
        {
            CheckTest(new[]{
                new Task0102.Point() { X = 0, Y = 0 },
                new Task0102.Point() { X = 100, Y = 0 },
                new Task0102.Point() { X = 0, Y = 100 },
                new Task0102.Point() { X = 0, Y = 0 } }, "In");
        }
    }
}
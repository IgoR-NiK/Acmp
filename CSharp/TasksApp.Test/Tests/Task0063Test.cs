using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0063Test
    {
        private static void CheckTest(int s, int p, Task0063.Result result)
        {
            var resultTest = Task0063.Solve(s, p);
            Assert.AreEqual(resultTest.X, result.X);
            Assert.AreEqual(resultTest.Y, result.Y);
        }

        [Test]
        public void Test1()
        {
            CheckTest(4, 4, new Task0063.Result { X = 2, Y = 2 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(5, 6, new Task0063.Result { X = 2, Y = 3 });
        }
    }
}
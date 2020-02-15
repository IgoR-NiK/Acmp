using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0092Test
    {
        private void CheckTest(int s, Task0092.Result result)
        {
            var resultTest = Task0092.Solve(s);
            Assert.AreEqual(resultTest.a, result.a);
            Assert.AreEqual(resultTest.b, result.b);
            Assert.AreEqual(resultTest.c, result.c);
        }

        [Test]
        public void Test1()
        {
            CheckTest(6, new Task0092.Result() { a = 1, b = 4, c = 1 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(24, new Task0092.Result() { a = 4, b = 16, c = 4 });
        }

        [Test]
        public void Test3()
        {
            CheckTest(60, new Task0092.Result() { a = 10, b = 40, c = 10 });
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0092Test
    {
        private static void CheckTest(int s, Task0092.Result result)
        {
            var resultTest = Task0092.Solve(s);
            Assert.That(resultTest.A, Is.EqualTo(result.A));
            Assert.That(resultTest.B, Is.EqualTo(result.B));
            Assert.That(resultTest.C, Is.EqualTo(result.C));
        }

        [Test]
        public void Test1()
        {
            CheckTest(6, new Task0092.Result { A = 1, B = 4, C = 1 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(24, new Task0092.Result { A = 4, B = 16, C = 4 });
        }

        [Test]
        public void Test3()
        {
            CheckTest(60, new Task0092.Result { A = 10, B = 40, C = 10 });
        }
    }
}

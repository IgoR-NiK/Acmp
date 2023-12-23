using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0004Test
    {
        private static void CheckTest(int k, string result)
        {
            var answer = Task0004.Solve(k);
            Assert.That(result, Is.EqualTo(answer));
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, "594");
        }

        [Test]
        public void Test2()
        {
            CheckTest(2, "297");
        }

        [Test]
        public void Test3()
        {
            CheckTest(7, "792");
        }
    }
}

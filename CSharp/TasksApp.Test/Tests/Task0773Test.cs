using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0773Test
    {
        private static void CheckTest(int k, int m, int result)
        {
            var resultTest = Task0773.Solve(k, m);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 2, 8);
        }

        [Test]
        public void Test2()
        {
            CheckTest(12, 4, 576);
        }
    }
}

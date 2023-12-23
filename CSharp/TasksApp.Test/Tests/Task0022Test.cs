using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0022Test
    {
        private static void CheckTest(int n, int output)
        {
            var test = Task0022.Solve(n);
            Assert.That(test, Is.EqualTo(output));
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 2);
        }

        [Test]
        public void Test2()
        {
            CheckTest(7, 3);
        }
    }
}
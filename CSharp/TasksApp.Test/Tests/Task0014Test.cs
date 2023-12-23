using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0014Test
    {
        private static void CheckTest(int a, int b, int output)
        {
            var test = Task0014.Solve(a, b);
            Assert.That(test, Is.EqualTo(output));
        }

        [Test]
        public void Test1()
        {
            CheckTest(36, 27, 108);
        }

        [Test]
        public void Test2()
        {
            CheckTest(39, 65, 195);
        }
    }
}
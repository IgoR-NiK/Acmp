using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1118Test
    {
        private static void CheckTest(int h, int a, int b, int result)
        {
            var actual = Task1118.Solve(h, a, b);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(10, 3, 2, 8);
        }
    }
}
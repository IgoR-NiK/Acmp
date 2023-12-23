using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0059Test
    {
        private static void CheckTest(int n, int k, int result)
        {
            var test = Task0059.Solve(n, k);
			Assert.That(result, Is.EqualTo(test));
        }

        [Test]
        public void Test1()
        {
			CheckTest(239, 8, 90);
        }

        [Test]
        public void Test2()
        {
            CheckTest(1000000000, 7, -34);
        }
    }
}
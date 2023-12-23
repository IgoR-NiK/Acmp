using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0542Test
    {
        private static void CheckTest(int n, int result)
        {
            var resultTest = Task0542.Solve(n);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(4, 1);
        }

		[Test]
		public void Test2()
		{
			CheckTest(6, 3);
		}
	}
}

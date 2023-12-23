using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0036Test
    {
        private static void CheckTest(int n, int result)
        {
            var test = Task0036.Solve(n);
			Assert.That(test, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 1);
        }

		[Test]
		public void Test2()
		{
			CheckTest(239, 39);
		}

		[Test]
		public void Test3()
		{
			CheckTest(3000, 353);
		}
    }
}
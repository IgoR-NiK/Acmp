using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0933Test
    {
        private static void CheckTest(int a, int b, int c, int t, int result)
        {
            var solution = Task0933.Solve(a, b, c, t);
			Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
			CheckTest(30, 2, 3, 30, 60);
        }

		[Test]
		public void Test2()
		{
			CheckTest(20, 1, 3, 30, 50);
		}
    }
}
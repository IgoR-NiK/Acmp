using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0664Test
    {
        private static void CheckTest(int k, int m, int n, int result)
        {
            var solution = Task0664.Solve(k, m, n);
            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void Test1()
        {
	        CheckTest(1, 1, 1, 2);
        }

		[Test]
		public void Test2()
		{
			CheckTest(2, 2, 1, 4);
		}
    }
}
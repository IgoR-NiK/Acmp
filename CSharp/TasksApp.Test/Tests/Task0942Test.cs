using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0942Test
    {
        private static void CheckTest(int[] tasks, int result)
        {
            var test = Task0942.Solve(tasks);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest(new[] { 40, 30, 60 }, 1);
        }

		[Test]
		public void Test2()
		{
			CheckTest(new[] { 10, 20, 30, 40 }, 1);
		}
    }
}
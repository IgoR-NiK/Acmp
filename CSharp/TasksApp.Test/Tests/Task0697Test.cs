using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0697Test
    {
        private static void CheckTest(int n, int v, int k, int result)
        {
            var solution = Task0697.Solve(n, v, k);
            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
	        CheckTest(8, 8, 2, 4);
        }

		[Test]
		public void Test2()
		{
			CheckTest(1, 1, 3, 1);
		}
    }
}
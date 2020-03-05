using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0580Test
    {
        private static void CheckTest(int a, int b, int c, int r, string result)
        {
            var solution = Task0580.Solve(a, b, c, r);
            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
	        CheckTest(1, 1, 1, 1, "NO");
        }

		[Test]
		public void Test2()
		{
			CheckTest(3, 4, 5, 1, "YES");
		}
    }
}
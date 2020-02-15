using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0935Test
    {
        private void CheckTest(int x1, int y1, int x2, int y2, string result)
        {
            var solution = Task0935.Solve(x1, y1, x2, y2);
			Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
			CheckTest(1, 1, 4, 4, "YES");
        }

		[Test]
		public void Test2()
		{
			CheckTest(1, 2, 7, 5, "NO");
		}
    }
}
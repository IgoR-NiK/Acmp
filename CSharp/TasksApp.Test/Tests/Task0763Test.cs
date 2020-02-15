using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0763Test
    {
        private void CheckTest(int x, int y, int result)
        {
            var solution = Task0763.Solve(x, y);
			Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
			CheckTest(1, 1, 0);
        }

		[Test]
		public void Test2()
		{
			CheckTest(1, 6, 1);
		}
    }
}
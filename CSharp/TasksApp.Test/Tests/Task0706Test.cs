using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0706Test
    {
        private static void CheckTest(double r, double x, double y, double result)
        {
            var solution = Task0706.Solve(r, x, y);
			Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
			CheckTest(10, 5, 5, 3.33);
        }

		[Test]
		public void Test2()
		{
			CheckTest(10, 10, 5, 6.67);
		}
    }
}
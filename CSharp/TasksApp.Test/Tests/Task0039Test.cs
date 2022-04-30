using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0039Test
    {
        private static void CheckTest(int[] prices, int result)
        {
            var test = Task0039.Solve(prices);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest(new[] { 73, 31, 96, 24, 46 }, 380);
        }

		[Test]
		public void Test2()
		{
			CheckTest(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100);
		}

		[Test]
		public void Test3()
		{
			CheckTest(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 55);
		}
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0606Test
    {
        private static void CheckTest(int a, int b, int c, bool result)
        {
            var solution = Task0606.Solve(a, b, c);
            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
	        CheckTest(3, 4, 5, true);
        }

		[Test]
		public void Test2()
		{
			CheckTest(1, 1, 5, false);
		}
		
		[Test]
		public void Test3()
		{
			CheckTest(1, 1, 2, false);
		}
    }
}
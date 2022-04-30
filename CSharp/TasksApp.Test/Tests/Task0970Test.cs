using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0970Test
    {
        private static void CheckTest(int a1, int a2, int a3, string result)
        {
            var test = Task0970.Solve(a1, a2, a3);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 5, 2, "YES");
        }

		[Test]
		public void Test2()
		{
			CheckTest(2, 2, 5, "NO");
		}

		[Test]
		public void Test3()
		{
			CheckTest(2, 2, 4, "YES");
		}
    }
}
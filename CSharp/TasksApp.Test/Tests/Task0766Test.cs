using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0766Test
    {
        private static void CheckTest(int n, int m, int k, string result)
        {
            var resultTest = Task0766.Solve(n, m, k);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(4, 5, 20, "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest(4, 5, 21, "NO");
        }

		[Test]
		public void Test3()
		{
			CheckTest(3, 2, 1, "YES");
		}
	}
}

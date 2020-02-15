using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0692Test
    {
        private void CheckTest(int n, string result)
        {
            var resultTest = Task0692.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1024, "YES");
        }

		[Test]
		public void Test2()
		{
			CheckTest(1000, "NO");
		}

		[Test]
		public void Test3()
		{
			CheckTest(23, "NO");
		}
	}
}

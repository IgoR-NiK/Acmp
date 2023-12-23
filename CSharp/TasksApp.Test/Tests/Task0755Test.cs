using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0755Test
    {
        private static void CheckTest(int x, int y, int z, string result)
        {
            var resultTest = Task0755.Solve(x, y, z);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 2, 1, "4");
        }

        [Test]
        public void Test2()
        {
			CheckTest(12, 13, 5, "20");
		}

		[Test]
		public void Test3()
		{
			CheckTest(2, 5, 9, "Impossible");
		}
	}
}

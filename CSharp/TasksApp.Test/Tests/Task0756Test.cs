using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0756Test
    {
        private static void CheckTest(int m, int n, int result)
        {
            var resultTest = Task0756.Solve(m, n);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 2, 1);
        }

        [Test]
        public void Test2()
        {
			CheckTest(2, 3, 2);
		}
	}
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0854Test
    {
        private static void CheckTest(int a, int b, string mode, int result)
        {
            var resultTest = Task0854.Solve(a, b, mode);
            Assert.AreEqual(resultTest, result);
		}

        [Test]
        public void Test1()
        {
            CheckTest(10, 20, "heat", 20);
        }

        [Test]
        public void Test2()
        {
            CheckTest(10, 20, "freeze", 10);
        }
	}
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0043Test
    {
        private static void CheckTest(string input, int result)
        {
            var test = Task0043.Solve(input);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest("00101110000110", 4);
        }

        [Test]
        public void Test2()
        {
            CheckTest("00", 2);
        }

        [Test]
        public void Test3()
        {
            CheckTest("111", 0);
        }
    }
}
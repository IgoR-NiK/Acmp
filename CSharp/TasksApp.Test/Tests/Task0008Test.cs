using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0008Test
    {
        private void CheckTest(int a, int b, int c, string output)
        {
            var test = Task0008.Solve(a, b, c);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest(8, 54, 432, "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest(16, 19, 777, "NO");
        }
    }
}
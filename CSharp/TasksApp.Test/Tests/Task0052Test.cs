using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0052Test
    {
        private void CheckTest(int n, string result)
        {
            var test = Task0052.Solve(n);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest(385916, "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest(123456, "NO");
        }

        [Test]
        public void Test3()
        {
            CheckTest(9450, "YES");
        }

        [Test]
        public void Test4()
        {
            CheckTest(1, "NO");
        }
    }
}
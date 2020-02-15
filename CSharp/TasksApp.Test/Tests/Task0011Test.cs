using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0011Test
    {
        private void CheckTest(int k, int n, string output)
        {
            var test = Task0011.Solve(k, n);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, 3, "1");
        }

        [Test]
        public void Test2()
        {
            CheckTest(2, 7, "21");
        }

        [Test]
        public void Test3()
        {
            CheckTest(3, 10, "274");
        }
    }
}
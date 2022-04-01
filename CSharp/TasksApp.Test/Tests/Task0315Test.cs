using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0315Test
    {
        private void CheckTest(string n, int result)
        {
            var solution = Task0315.Solve(n);

            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
            CheckTest("123", 4);
        }

        [Test]
        public void Test2()
        {
            CheckTest("ABCDEF", 16);
        }

        [Test]
        public void Test3()
        {
            CheckTest("AD%AF", -1);
        }

        [Test]
        public void Test4()
        {
            CheckTest("03025", 6);
        }

        [Test]
        public void Test5()
        {
            CheckTest("abc", -1);
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0025Test
    {
        private void CheckTest(int a, int b, char output)
        {
            var test = Task0025.Solve(a, b);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 7, '<');
        }

        [Test]
        public void Test2()
        {
            CheckTest(-7, -12, '>');
        }

        [Test]
        public void Test3()
        {
            CheckTest(13, 13, '=');
        }
    }
}
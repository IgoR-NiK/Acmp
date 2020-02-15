using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0001Test
    {
        private static void CheckTest(int a, int b, int result)
        {
            var answer = Task0001.Solve(a, b);
            Assert.AreEqual(result, answer);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 3, 5);
        }

        [Test]
        public void Test2()
        {
            CheckTest(8, 9, 17);
        }
    }
}

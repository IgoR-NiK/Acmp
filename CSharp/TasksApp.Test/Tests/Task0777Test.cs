using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0777Test
    {
        private static void CheckTest(int s, int t, int result)
        {
            var resultTest = Task0777.Solve(s, t);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(10, 12, 2);
        }

        [Test]
        public void Test2()
        {
            CheckTest(12, 10, 10);
        }
    }
}

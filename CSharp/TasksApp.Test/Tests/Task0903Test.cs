using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0903Test
    {
        private static void CheckTest(int n, int result)
        {
            var resultTest = Task0903.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 4);
        }
    }
}

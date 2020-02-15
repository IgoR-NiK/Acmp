using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0195Test
    {
        private void CheckTest(int n, int a, int b, int result)
        {
            var resultTest = Task0195.Solve(n, a, b);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 2, 3, 60);
        }

        [Test]
        public void Test2()
        {
            CheckTest(14, 23, 5, 3220);
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0529Test
    {
        private void CheckTest(int x1, int y1, int x2, int y2, double result)
        {
            var actual = Task0529.Solve(x1, y1, x2, y2);
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 4, 8, 4, 5);
        }
    }
}

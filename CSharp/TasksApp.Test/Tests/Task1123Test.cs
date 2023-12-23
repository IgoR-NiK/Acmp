using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1123Test
    {
        private static void CheckTest(int x1, int y1, int x2, int y2, string result)
        {
            var actual = Task1123.Solve(x1, y1, x2, y2);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(4, 4, 5, 6, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(2, 3, 3, 2, "NO");
        }
    }
}
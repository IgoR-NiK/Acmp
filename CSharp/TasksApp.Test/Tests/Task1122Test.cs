using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1122Test
    {
        private void CheckTest(int x1, int y1, int x2, int y2, string result)
        {
            var actual = Task1122.Solve(x1, y1, x2, y2);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 3, 4, 3, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(3, 3, 5, 3, "NO");
        }
    }
}
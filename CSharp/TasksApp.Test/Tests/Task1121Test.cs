using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1121Test
    {
        private void CheckTest(int x1, int y1, int x2, int y2, string result)
        {
            var actual = Task1121.Solve(x1, y1, x2, y2);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 4, 5, 8, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(5, 4, 7, 6, "YES");
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(1, 1, 2, 3, "NO");
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1124Test
    {
        private static void CheckTest(int x1, int y1, int x2, int y2, string result)
        {
            var actual = Task1124.Solve(x1, y1, x2, y2);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 2, 5, 4, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(5, 6, 5, 7, "YES");
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(2, 3, 3, 4, "NO");
        }
    }
}
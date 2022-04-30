using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0907Test
    {
        private static void CheckTest(int w, int h, int r, string result)
        {
            var resultTest = Task0907.Solve(w, h, r);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(4, 7, 2, "YES");
        }

        [Test]
        public void Test2()
        {
			CheckTest(4, 7, 3, "NO");
		}
    }
}

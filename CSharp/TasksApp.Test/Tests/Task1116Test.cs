using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1116Test
    {
        private static void CheckTest(int h1, int m1, int s1, int h2, int m2, int s2, int result)
        {
            var actual = Task1116.Solve(h1, m1, s1, h2, m2, s2);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, 1, 1, 2, 2, 2, 3661);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(1, 2, 30, 1, 3, 20, 50);
        }
    }
}
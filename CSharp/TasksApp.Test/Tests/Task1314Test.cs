using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1314Test
    {
        private static void CheckTest(int l1, int w1, int h1, int l2, int w2, int h2, int lc, int wc, int hc, string result)
        {
            var actual = Task1314.Solve(l1, w1, h1, l2, w2, h2, lc, wc, hc);
            
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 2, 3, 3, 3, 3, 3, 5, 3, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(2, 3, 3, 3, 2, 3, 4, 4, 4, "YES");
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(4, 1, 2, 3, 3, 2, 4, 3, 4, "YES");
        }
        
        [Test]
        public void Test4()
        {
            CheckTest(1, 1, 4, 1, 1, 3, 10, 10, 3, "NO");
        }
        
        [Test]
        public void Test5()
        {
            CheckTest(3, 2, 2, 3, 1, 2, 5, 2, 3, "NO");
        }
    }
}
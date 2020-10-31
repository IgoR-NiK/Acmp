using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0499Test
    {
        private void CheckTest(int k, int w, int a1, int b1, int a2, int b2, int a3, int b3, string result)
        {
            var actual = Task0499.Solve(k, w, a1, b1, a2, b2, a3, b3);
            
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(10, 10, 5, 5, 6, 6, 4, 5, "YES");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(10, 10, 5, 5, 6, 6, 7, 7, "NO");
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0394Test
    {
        private static void CheckTest(int n, int m, int result)
        {
            var test = Task0394.Solve(n, m);

            Assert.AreEqual(result, test);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 5, 2);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(2, 4, 1);
        }
    }
}
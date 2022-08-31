using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0514Test
    {
        private static void CheckTest(int k, int result)
        {
            var actual = Task0514.Solve(k);
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, 1);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(4, 2);
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(6, 3);
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0002Test
    {
        private static void CheckTest(int n, long result)
        {
            var answer = Task0002.Solve(n);
            Assert.AreEqual(result, answer);            
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 15);
        }

        [Test]
        public void Test2()
        {
            CheckTest(9, 45);
        }

        [Test]
        public void Test3()
        {
            CheckTest(-4, -9);
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0003Test
    {
        private static void CheckTest(int a, long result)
        {
            var answer = Task0003.Solve(a);
            Assert.AreEqual(result, answer);                 
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 25);
        }

        [Test]
        public void Test2()
        {
            CheckTest(75, 5625);
        }

        [Test]
        public void Test3()
        {
            CheckTest(4255, 18105025);
        }
    }
}

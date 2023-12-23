using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1112Test
    {
        private static void CheckTest(int n, int result)
        {
            var actual = Task1112.Solve(n);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(100, 1);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(123, 6);
        }
    }
}
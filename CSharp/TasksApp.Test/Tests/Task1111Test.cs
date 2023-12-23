using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1111Test
    {
        private static void CheckTest(int n, int result)
        {
            var actual = Task1111.Solve(n);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(123, 2);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(46, 4);
        }
    }
}
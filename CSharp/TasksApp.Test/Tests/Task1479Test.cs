using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1479Test
    {
        private static void CheckTest(long a, long b, long result)
        {
            var actual = Task1479.Solve(a, b);
            
			Assert.That(result, Is.EqualTo(actual));            
        }

        [Test]
        public void Test1()
        {
            CheckTest(27, 4, 3);
        }

        [Test]
        public void Test2()
        {
            CheckTest(-15, 4, 1);
        }

        [Test]
        public void Test3()
        {
            CheckTest(113, -3, 2);
        }

        [Test]
        public void Test4()
        {
            CheckTest(-15, -7, 6);
        }
    }
}
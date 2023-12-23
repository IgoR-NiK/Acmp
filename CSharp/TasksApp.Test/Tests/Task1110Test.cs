using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1110Test
    {
        private static void CheckTest(int n, int result)
        {
            var actual = Task1110.Solve(n);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 5);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(273, 3);
        }
    }
}
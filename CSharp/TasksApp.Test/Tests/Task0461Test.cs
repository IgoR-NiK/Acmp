using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0461Test
    {
        private static void CheckTest(int[] input, int result)
        {
            var actual = Task0461.Solve(input);
            
            Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 5, 5, 7 }, 6);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { 4, 2, 1, 3, 7 }, 5);
        }
    }
}

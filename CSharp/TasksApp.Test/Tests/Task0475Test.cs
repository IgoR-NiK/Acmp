using System.Collections.Generic;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task075Test
    {
        private static void CheckTest(IEnumerable<int> numbers, bool result)
        {
            var actual = Task0475.Solve(numbers);
            
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 80, 50, 10, 30, 70, 40, 20, 60, 90 }, true);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { 1, 2, 3, 5 }, false);
        }
    }
}

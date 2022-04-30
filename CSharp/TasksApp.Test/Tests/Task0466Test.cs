using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0466Test
    {
        private static void CheckTest(int n, int result)
        {
            var actual = Task0466.Solve(n);
            
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 1);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(5, 3);
        }
    }
}

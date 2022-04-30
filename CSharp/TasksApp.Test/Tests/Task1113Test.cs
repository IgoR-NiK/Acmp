using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1113Test
    {
        private static void CheckTest(int a, int b, bool result)
        {
            var actual = Task1113.Solve(a, b);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, 6, true);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(6, 3, true);
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(5, 7, false);
        }
    }
}
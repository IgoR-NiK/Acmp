using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1167Test
    {
        private static void CheckTest(string input, int result)
        {
            var actual = Task1167.Solve(input);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest("M(5,m(6,8))", 6);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest("M(m(1,2),m(4,3))", 3);
        }
        
        [Test]
        public void Test3()
        {
            CheckTest("0", 0);
        }
    }
}
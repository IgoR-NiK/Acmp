using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0757Test
    {
        private static void CheckTest(long c, long h, long o, long result)
        {
            var resultTest = Task0757.Solve(c, h, o);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 6, 1, 1);
        }

        [Test]
        public void Test2()
        {
			CheckTest(10, 5, 12, 0);
		}
        
        [Test]
        public void Test3()
        {
            CheckTest(18, 35, 3, 3);
        }
	}
}

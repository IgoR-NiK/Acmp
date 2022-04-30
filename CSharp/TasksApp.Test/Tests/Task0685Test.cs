using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0685Test
    {
        private static void CheckTest(int[] a, int[] b, int result)
        {
            var resultTest = Task0685.Solve(a, b);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 14);
        }		
	}
}
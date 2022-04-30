using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1003Test
    {
        private static void CheckTest(long x, long y, long z, long result)
        {
            var actual = Task1003.Solve(x, y, z);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, 1, 1, 20);
        }
    }
}
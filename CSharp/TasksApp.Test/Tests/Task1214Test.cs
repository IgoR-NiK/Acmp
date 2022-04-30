using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1214Test
    {
        private static void CheckTest(int[] numbers, int search, int result)
        {
            var actual = Task1214.Solve(numbers, search);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 1, 2, 3, 4, 5 }, 3, 1);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { 5, 3, 4, 5, 5, 2, 1 }, 5, 3);
        }
    }
}
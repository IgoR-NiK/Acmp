using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0818Test
    {
        private static void CheckTest(int[] numbers, int result)
        {
            var resultTest = Task0818.Solve(numbers);
            Assert.AreEqual(resultTest, result);
		}

        [Test]
        public void Test1()
        {
	        CheckTest(new[] { 1 }, 1);
        }

        [Test]
        public void Test2()
        {
	        CheckTest(new[] { 2, 5, 4 }, 9);
        }
	}
}

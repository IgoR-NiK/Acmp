using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1132Test
    {
        private void CheckTest(string[] input, int result)
        {
            var actual = Task1132.Solve(input);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { "1", "7", "9", "0", "5" }, 3);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { "1", "2", "3", "4", "5", "0", "6", "7", "0", "8", "9", "10" }, 5);
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(new[] { "0" }, 0);
        }
    }
}
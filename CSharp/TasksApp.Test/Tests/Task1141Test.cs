using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1141Test
    {
        private void CheckTest(string[] input, int result)
        {
            var actual = Task1141.Solve(input);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { "1", "7", "7", "9", "1", "0" }, 2);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { "1", "2", "3", "3", "3", "3", "4", "5", "3", "4", "0", "5" }, 4);
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(new[] { "0" }, 1);
        }
    }
}
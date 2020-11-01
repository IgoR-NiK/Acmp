using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1117Test
    {
        private void CheckTest(int n, (int h, int m) result)
        {
            var actual = Task1117.Solve(n);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, (10, 35));
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(3, (11, 35));
        }
    }
}
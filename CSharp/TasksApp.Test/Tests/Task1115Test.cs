using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1115Test
    {
        private void CheckTest(int n, int k, (int a, int b, int c) result)
        {
            var actual = Task1115.Solve(n, k);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(7, 30, (4, 2, 5));
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(5, 15, (3, 0, 0));
        }
    }
}
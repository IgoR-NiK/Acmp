using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1114Test
    {
        private static void CheckTest(int v, int t, int result)
        {
            var actual = Task1114.Solve(v, t);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(60, 2, 12);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(-1, 1, 109);
        }
    }
}
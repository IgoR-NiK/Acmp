using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0364Test
    {
        private static void CheckTest(long m, long n, long[] result)
        {
            var test = Task0364.Solve(m, n);
            
            Assert.AreEqual(result.Length, test.Count);

            for (var i = 0; i < result.Length; i++)
                Assert.AreEqual(test[i], result[i]);
        }

        [Test]
        public void Test1()
        {
            CheckTest(6, 6, new long[] { 6 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(4, 5, new long[] { });
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(5, 30, new long[] { 6, 28});
        }
        
        [Test]
        public void Test4()
        {
            CheckTest(2305843008139952128, 2305843008139952128, new[] { 2305843008139952128});
        }
    }
}

using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0504Test
    {
        private static void CheckTest(int k, char[] result)
        {
            var actual = Task0504.Solve(k);
            Assert.AreEqual(result[0], actual[0]);
            Assert.AreEqual(result[1], actual[1]);
            Assert.AreEqual(result[2], actual[2]);
        }

        [Test]
        public void Test1()
        {
            CheckTest(1, new[] { 'V', 'G', 'C' });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(5, new[] { 'C', 'V', 'G' });
        }
    }
}

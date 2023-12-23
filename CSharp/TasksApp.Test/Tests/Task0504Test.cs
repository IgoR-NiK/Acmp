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
            Assert.That(result[0], Is.EqualTo(actual[0]));
            Assert.That(result[1], Is.EqualTo(actual[1]));
            Assert.That(result[2], Is.EqualTo(actual[2]));
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

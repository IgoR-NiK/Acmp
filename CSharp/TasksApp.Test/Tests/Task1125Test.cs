using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1125Test
    {
        private static void CheckTest(int n, int[] result)
        {
            var actual = Task1125.Solve(n).ToArray();
			Assert.That(result.Length, Is.EqualTo(actual.Length));

            for (var i = 0; i < result.Length; i++)
            {
                Assert.That(result[i], Is.EqualTo(actual[i]));
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(10, new[] { 1, 4, 9 });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(50, new[] { 1, 4, 9, 16, 25, 36, 49 });
        }
    }
}
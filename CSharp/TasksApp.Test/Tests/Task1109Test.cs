using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1109Test
    {
        private static void CheckTest(int n, string[] results)
        {
            var actual = Task1109.Solve(n);
			Assert.That(results.Length, Is.EqualTo(actual.Length));

            for (var i = 0; i < results.Length; i++)
            {
                Assert.That(results[i], Is.EqualTo(actual[i]));
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(13, new[]
            {
                "The next number for the number 13 is 14.",
                "The previous number for the number 13 is 12."
            });
        }
    }
}
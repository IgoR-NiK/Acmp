using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1396Test
    {
        private static void CheckTest(int[] input, int[] result)
        {
            var actual = Task1396.Solve(input);
            
			Assert.That(result.Length, Is.EqualTo(actual.Length));
            for (var i = 0; i < result.Length; i++)
            {
                Assert.That(result[i], Is.EqualTo(actual[i]));
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 1, 3, 4, 2, 5 }, new[] { 1, 3, 3, 4 });
        }
    }
}
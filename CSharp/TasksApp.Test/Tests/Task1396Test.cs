using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1396Test
    {
        private void CheckTest(int[] input, int[] result)
        {
            var actual = Task1396.Solve(input);
            
			Assert.AreEqual(result.Length, actual.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], actual[i]);
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 1, 3, 4, 2, 5 }, new[] { 1, 3, 3, 4 });
        }
    }
}
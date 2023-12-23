using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0234Test
    {
        private static void CheckTest(int[][] field, int[][] result)
        {
            var solution = Task0234.Solve(field);
            
            Assert.That(solution.Length, Is.EqualTo(result.Length));
            for (var i = 0; i < result.Length; i++)
            {
                Assert.That(solution[i].Length, Is.EqualTo(result[i].Length));

                for (var j = 0; j < result[i].Length; j++)
                {
                    Assert.That(solution[i][j], Is.EqualTo(result[i][j]));
                }
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[]
                {
                    new[] { 0, 0, 0, 0, 0, 0, 0, -1, 0 },
                    new[] { 0, 0, -1, 0, 0, 0, 0, 0, 0 },
                    new[] { 0, -1, -1, 0, 0, 0, 0, 0, 0 },
                    new[] { 0, 0, -1, 0, 0, 0, 0, 0, 0 },
                    new[] { 0, 0, 0, 0, 0, 0, -1, 0, 0 },
                    new[] { 0, 0, 0, 0, 0, 0, -1, 0, 0 },
                    new[] { -1, -1, -1, -1, -1, -1, -1, -1, 0 },
                    new[] { -1, 0, -1, 0, -1, 0, -1, 0, 0 },
                    new[] { 0, 0, -1, 0, -1, -1, -1, 0, 0 },
                    new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                },
                new[]
                {
                    new[] { 0, 1, 1, 1, 0, 0, 1, -1, 1 },
                    new[] { 1, 3, -1, 2, 0, 0, 1, 1, 1 },
                    new[] { 1, -1, -1, 3, 0, 0, 0, 0, 0 },
                    new[] { 1, 3, -1, 2, 0, 1, 1, 1, 0 },
                    new[] { 0, 1, 1, 1, 0, 2, -1, 2, 0 },
                    new[] { 2, 3, 3, 3, 3, 5, -1, 4, 1 },
                    new[] { -1, -1, -1, -1, -1, -1, -1, -1, 1 },
                    new[] { -1, 6, -1, 7, -1, 8, -1, 4, 1 },
                    new[] { 1, 3, -1, 4, -1, -1, -1, 2, 0 },
                    new[] { 0, 1, 1, 2, 2, 3, 2, 1, 0 }
                });
        }
    }
}
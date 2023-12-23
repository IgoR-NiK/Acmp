using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0197Test
    {
        private static void CheckTest(int n, int[][] result)
        {
            var solution = Task0197.Solve(n);

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
            CheckTest(
                3,
                new[]
                {
                    new [] { 1, 3, 4 },
                    new [] { 2, 5, 8 },
                    new [] { 6, 7, 9 }
                });
        }

        [Test]
        public void Test2()
        {
            CheckTest(
                4,
                new[]
                {
                    new [] { 1, 3, 4, 10 },
                    new [] { 2, 5, 9, 11 },
                    new [] { 6, 8, 12, 15 },
                    new [] { 7, 13, 14, 16 }
                });
        }

        [Test]
        public void Test3()
        {
            CheckTest(
                5,
                new[]
                {
                    new [] { 1, 3, 4, 10, 11 },
                    new [] { 2, 5, 9, 12, 19 },
                    new [] { 6, 8, 13, 18, 20 },
                    new [] { 7, 14, 17, 21, 24 },
                    new [] { 15, 16, 22, 23, 25 }
                });
        }
    }
}
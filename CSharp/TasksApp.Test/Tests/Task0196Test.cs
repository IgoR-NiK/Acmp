using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0196Test
    {
        private static void CheckTest(int n, int[][] result)
        {
            var solution = Task0196.Solve(n);

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
                    new [] { 1, 2, 3 },
                    new [] { 8, 9, 4 },
                    new [] { 7, 6, 5 }
                });
        }

        [Test]
        public void Test2()
        {
            CheckTest(
                4,
                new[]
                {
                    new [] { 1, 2, 3, 4 },
                    new [] { 12, 13, 14, 5 },
                    new [] { 11, 16, 15, 6 },
                    new [] { 10, 9, 8, 7 }
                });
        }

        [Test]
        public void Test3()
        {
            CheckTest(
                5,
                new[]
                {
                    new [] { 1, 2, 3, 4, 5 },
                    new [] { 16, 17, 18, 19, 6 },
                    new [] { 15, 24, 25, 20, 7 },
                    new [] { 14, 23, 22, 21, 8 },
                    new [] { 13, 12, 11, 10, 9 }
                });
        }
    }
}
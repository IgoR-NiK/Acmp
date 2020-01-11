using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0196Test
    {
        private void CheckTest(int n, int[][] result)
        {
            var solution = Task0196.Solve(n);

            Assert.AreEqual(solution.Length, result.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(solution[i].Length, result[i].Length);
                for (var j = 0; j < result[i].Length; j++)
                {
                    Assert.AreEqual(solution[i][j], result[i][j]);
                }
            }
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(
                3,
                new int[][] {
                    new [] { 1, 2, 3 },
                    new [] { 8, 9, 4 },
                    new [] { 7, 6, 5 }
                });
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(
                4,
                new int[][] {
                    new [] { 1, 2, 3, 4 },
                    new [] { 12, 13, 14, 5 },
                    new [] { 11, 16, 15, 6 },
                    new [] { 10, 9, 8, 7 }
                });
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(
                5,
                new int[][] {
                    new [] { 1, 2, 3, 4, 5 },
                    new [] { 16, 17, 18, 19, 6 },
                    new [] { 15, 24, 25, 20, 7 },
                    new [] { 14, 23, 22, 21, 8 },
                    new [] { 13, 12, 11, 10, 9 }
                });
        }
    }
}
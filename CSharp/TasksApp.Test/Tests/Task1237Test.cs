using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1237Test
    {
        private void CheckTest(int[,] a, int[,] b, int[,] result)
        {
            var actual = Task1237.Solve(a, b);
            
			Assert.AreEqual(result.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(result.GetLength(1), actual.GetLength(1));
            
            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(result[i, j], actual[i, j]);
                }
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { 4, -2, 6, 1 },
                { -1, 7, -4, 3 },
                { 5, 3, 9, 4 }
            }, new[,]
            {
                { 2, -3, 2, 7 },
                { 5, 1, -1, 0 },
                { -2, 3, -4, 2 }
            }, new int[,]
            {
                { 6, -5, 8, 8 },
                { 4, 8, -5, 3 },
                { 3, 6, 5, 6 }
            });
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1238Test
    {
        private void CheckTest(int[,] a, int[,] b, int[,] result)
        {
            var actual = Task1238.Solve(a, b);
            
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
                { 2, 3 },
                { -1, 4 }
            }, new[,]
            {
                { 2, -3, 4 },
                { 3, 1, 0 }
            }, new int[,]
            {
                { 13, -3, 8 },
                { 10, 7, -4 }
            });
        }
    }
}
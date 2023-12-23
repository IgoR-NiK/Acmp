using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1238Test
    {
        private static void CheckTest(int[,] a, int[,] b, int[,] result)
        {
            var actual = Task1238.Solve(a, b);
            
			Assert.That(result.GetLength(0), Is.EqualTo(actual.GetLength(0)));
            Assert.That(result.GetLength(1), Is.EqualTo(actual.GetLength(1)));
            
            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Assert.That(result[i, j], Is.EqualTo(actual[i, j]));
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
            }, new[,]
            {
                { 13, -3, 8 },
                { 10, 7, -4 }
            });
        }
    }
}
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1232Test
    {
        private void CheckTest(int[,] numbers, Task1232.Result result)
        {
            var actual = Task1232.Solve(numbers);
            
			Assert.AreEqual(result.RowsSum.Length, actual.RowsSum.Length);
            for (var i = 0; i < result.RowsSum.Length; i++)
            {
                Assert.AreEqual(result.RowsSum[i], actual.RowsSum[i]);
            }
            
            Assert.AreEqual(result.ColumnsSum.Length, actual.ColumnsSum.Length);
            for (var i = 0; i < result.ColumnsSum.Length; i++)
            {
                Assert.AreEqual(result.ColumnsSum[i], actual.ColumnsSum[i]);
            }
        }

        [Test]
        public void Test1()
        {
            var numbers = new[,]
            {
                { 5, 9, 2, 6 },
                { 6, 2, 4, 3 },
                { 1, 2, 8, 7 }
            };

            CheckTest(numbers, new Task1232.Result(numbers)
            {
                RowsSum = new[] { 22, 15, 18 },
                ColumnsSum = new[] { 12, 13, 14, 16 }
            });
        }
    }
}
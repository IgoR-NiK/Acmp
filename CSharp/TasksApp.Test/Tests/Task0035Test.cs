using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0035Test
    {
        private void CheckTest(int[] n, int[] m, long[] result)
        {
            var test = Task0035.Solve(n, m);
            for (var i = 0; i < n.Length; i++)
            {
                Assert.AreEqual(test[i], result[i]);
            }
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(new[] { 2, 13, 5, 18 }, new[] { 0, 20, 23, 6 }, new long[] { 44344, 48134, 45699, 49458 });
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(new[] { 15, 1000 }, new[] { 20, 26000 }, new long[] { 48767, 1340237 });
        }
    }
}